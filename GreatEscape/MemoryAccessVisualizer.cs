using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatEscape
{

    public interface IMemoryAccessVisualizer
    {
        public void NewPC(ushort p); //update the visualizer with a new pc location
        public void RequestScreenUpdate();
        public void SetSpectrum(Spectrum zx);
    }

    public class MemoryAccessVisualizer : IMemoryAccessVisualizer
    {
        private static int SIZE = 65536 / 8;  //each line holds spec mem bits, calculate size in bytes
        //private static int LINES = 100;
        //private static int LINES = 33;
        private static int LINES = 2;
        private byte[] bitmap;
        private int y = 0;  //current line to write pixels to


        //we will have a 1500 pixel window into the giant bitmap
        int windowX = -1;

        public Spectrum m_zx;
        public MemoryAccessVisualizer()
        {
            //create memory for the giant bitmap
            bitmap = new byte[SIZE * LINES];
        }

        public void SetSpectrum(Spectrum zx)
        {
            m_zx = zx;
        }

        private int skip = 0;
        private bool m_screenUpdateRequested = false;

        public void NewPC(ushort p)
        {
            UpdateBitmap(p);

            if (m_screenUpdateRequested)
            {
                m_screenUpdateRequested = false;
                RefreshDisplay();
            }

            if (skip % 10900 == 0)
            {
                RefreshDisplay();
            }
            skip++;
        }

        public void RequestScreenUpdate()
        {
            m_screenUpdateRequested = true;
        }


        public void UpdateBitmap(ushort p)
        {
            //turn on pixel at p
            //if it is on, go to next line
            (var x, var mask) = FormAddressAndBITPOS(p);
            int valueOfCur = bitmap[x + y * SIZE] & mask;
            if (valueOfCur > 0) //check if the bit is on
            {
                y++;
                if (y >= LINES) y = 0;
            }

            byte old = bitmap[x + y * SIZE];
            bitmap[x + y * SIZE] = (byte)(old | mask); //bitwise OR to turn on the bit


        }

        private (int, byte) FormAddressAndBITPOS(ushort x)
        {
            //from x address (actual memory address, but in this case our giant bitmap coordinate
            //create actual loc inside the bitmap
            int adr = x / 8;
            //byte mask = (byte)(x % 8);
            byte mask = bits[x % 8];
            return (adr, mask);
        }
        private static byte[] bits = new byte[]{ 128, 64, 32, 16, 8, 4, 2, 1};


        private FormMemoryAccessChart m_chartForm;
        private void RefreshDisplay()
        {
            if( m_chartForm == null)
            {
                m_chartForm = new FormMemoryAccessChart( this);
                m_chartForm.StartPosition = FormStartPosition.Manual;
                m_chartForm.Location = new Point(2700, -200);
                m_chartForm.Show();
            }
            m_chartForm.Refresh();
        }


        private static int max_dx = 0;  //largest dx found so far, looking for the pixels on the right side
        public void Paint(Graphics g)
        {
            int WINDOWSIZE = 2048;

            Brush black = Brushes.Black;

            //paint everything we'll go from there
            for (int y = 0; y < LINES; y++)
            {
                for (int x = 0; x < 65536; x++)
                {
                    //what is the gbitmap adr?
                    int adr = y * SIZE + (x / 8);
                    int mask = 128 >> (x % 8);
                    int val = bitmap[adr] & mask;
                    if (val > 0)
                    {
                        //calc display x and y coords,   each giant bitmap line will be split into 32 lines on the screen
                        int dx = x % WINDOWSIZE;
                        int extra = x / WINDOWSIZE; ;

                        int dy = y * (65536 / WINDOWSIZE) + extra;

                        g.FillRectangle(black, dx, dy, 1, 1);


                        //debug, update max_dx
                        if ( dx > max_dx)
                        {
                            string dxs = String.Format("0x{0:X}", dx);
                            max_dx = dx;
                        }

                    }




                }
            }


            /*
            int screen_start = 16384 + 0;

            for (int y = 0; y < 192; y++)
            {

                //get address y
                int adr;
                //adr = screen_start + y * 32;

                int third = y / 64;
                int char_row = y % 8;
                int block_row = (y % 64) / 8;

                //if (y == 111) return;

                adr = screen_start + (third * 32 * 8 * 8) + (char_row * 256) + (block_row * 32);

                for (int x = 0; x < 256; x += 8)
                {

                    for (int i = 0; i < 8; i++)
                    {
                        int bitmask = (128 >> i);
                        int membyte = ram[adr];
                        if ((membyte & bitmask) > 0)
                        {
                            //g.FillRectangle(black, x +i, y, 1, 1);
                            //g.FillRectangle(black, 2*(x + i), 2*y, 2, 2);
                            g.FillRectangle(black, 4 * (x + i), 4 * y, 4, 4);

                        }
                    }

                    adr++;


                }
            }

            */


        }

        public void PaintMemAccess(Graphics g)
        {
            m_zx.PaintMemAccess(g);

        }

       

    } //end class





}
