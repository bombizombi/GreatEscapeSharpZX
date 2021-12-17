using System.Diagnostics;

namespace GreatEscape
{
    public partial class FormZX : Form
    {

        private int m_timerLoopTimes = 50000; //might be wrong
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool enabled = checkBoxTimerEnabled.Checked;
            if (!enabled) return;

            //Loop(m_timerLoopTimes);
            LoopX(m_timerLoopTimes);

        }
        private void pictureScreen_Paint(object sender, PaintEventArgs e)
        {
            //m_zx.DrawScreen(e.Graphics);

            //turn this on to draw screen from mem
            //m_zx.DrawScreen2(e.Graphics);
            //m_screen.Paint3(e.Graphics, m_zx.GetRam());

            //Screen.Paint3( e.Graphics, m_Xmem.ram );

            //this to draw from m_zx emulator
            //m_screen.Paint4(e.Graphics, m_zx.GetRam());


            if (m_Xmem != null)
            {

                //this to draw from X emulator
                //m_zx.DrawScreenFromRAM(e.Graphics, m_Xmem.ram);
                m_screen.Paint4(e.Graphics, m_Xmem.ram);

            }

        }


        public FormZX()
        {
            InitializeComponent();

            m_keyboard = new Keyboard();
            m_screen = new Screen(); //lol


        }


        private Spectrum m_zx;

        private Keyboard m_keyboard;
        private Screen m_screen;

        private void StartSpectrum()
        {

            string gefile = "ge.z80";
            //string gefile = "He.z80";
            byte[] ge = File.ReadAllBytes(gefile);


            IMemoryAccessVisualizer viz = new MemoryAccessVisualizer();

            Spectrum zx = new Spectrum(ge, viz, m_keyboard);

            m_zx = zx;

            viz.SetSpectrum(zx);
        }

        private void UpdateGUIold()
        {
            textBoxPC.Text = m_zx.DisplayPC();
        }


        /*      private void buttonFillScr_Click(object sender, EventArgs e)
                {
                    for (int i = 0; i < 65536; i++)
                    {
                        m_zx.Poke(i, 1);
                    }

                    for (int i = 16384; i < 16384 + 3 * 2048; i++)
                    {
                        m_zx.Poke(i, 255);

                        pictureScreen.Invalidate();
                        Thread.Sleep(1);
                    }
                }*/






        private void buttonDraw_Click(object sender, EventArgs e)
        {
            pictureScreen.Invalidate();
        }

        private void pictureScreen_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //StartSpectrum();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            m_zx.RequestScreenUpdate();

            m_zx.Step();

            UpdateGUI();

        }

        private void buttonLoopSteps_Click(object sender, EventArgs e)
        {
            m_zx.LoopSteps(pictureScreen);
            pictureScreen.Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            StartSpectrum();
        }

        private void buttonKey1_Click(object sender, EventArgs e)
        {

        }



        private void buttonLoop10k_Click(object sender, EventArgs e)
        {
            int loops = 10000;
            loops = 100000;
            m_zx.LoopSteps(pictureScreen, loops);

            UpdateGUI();
        }

        private void buttonDebugAtribs_Click(object sender, EventArgs e)
        {
            m_zx.DebugAttribs();
        }

        private void checkBoxKey1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKey1(newstate);
        }
        private void checkBoxKey2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKey2(newstate);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKey3(newstate);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKey4(newstate);
        }



        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKey0(newstate);
        }

        private void checkBoxY_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKeyY(newstate);
        }
        private void checkBoxKeySpace_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKeySpace(newstate);
        }
        private void checkBoxBreak_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            bool newstate = a.Checked;
            m_keyboard.SetKeyBreak(newstate);
        }

        private void textBoxPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoopSmall_Click(object sender, EventArgs e)
        {
            int loops = 20000;
            m_zx.LoopSteps(pictureScreen, loops);

            UpdateGUI();
            //pictureScreen.Invalidate();

        }

        private void Loop( int steps)
        {
            m_zx.LoopSteps(pictureScreen, steps);
            UpdateGUI();
        }


        private void UpdateGUI()
        {
            pictureScreen.Invalidate();
            textBoxPC.Text = m_zx.DisplayPC();

            string dbg = "";
            if( m_zx.dbg_rez != null) dbg = m_zx.dbg_rez.ToString();
            if (dbg.Length < 100)
            {
                textBoxRez.Text = m_zx.DisplayRegisters() + dbg;
            }else
            {
                //Debugger.Break();
            }
        }

        private void buttonLoop10_Click(object sender, EventArgs e)
        {
            Loop(10);
        }

        private void buttonLoop100_Click(object sender, EventArgs e)
        {
            Control tb = sender as Control;
            string s = tb.Text;
            int x = int.Parse(s);
            Loop(x);
        }

        /*
        private int m_timerLoopTimes = 50000; //might be wrong
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool enabled = checkBoxTimerEnabled.Checked;
            if (!enabled) return;

            Loop(m_timerLoopTimes);
            //LoopX(m_timerLoopTimes);

        }*/


        private void buttonLogInstructions_Click(object sender, EventArgs e)
        {
            m_zx.DebugStartInstructionLog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m_zx.DebugStopIL();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            m_zx.DebugROM();
        }

        private void FormZX_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.D1)
            {
                                m_keyboard.SetKey1(true);
            }
            if (e.KeyCode == Keys.D2) m_keyboard.SetKey2(true);
            if (e.KeyCode == Keys.D3) m_keyboard.SetKey3(true);
            if (e.KeyCode == Keys.D4) m_keyboard.SetKey4(true);
            if (e.KeyCode == Keys.D0) m_keyboard.SetKey0(true);
            if (e.KeyCode == Keys.Y) m_keyboard.SetKeyY(true);

        }

        private void FormZX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                m_keyboard.SetKey1(false);
            }
            if (e.KeyCode == Keys.D2) m_keyboard.SetKey2(false);
            if (e.KeyCode == Keys.D3) m_keyboard.SetKey3(false);
            if (e.KeyCode == Keys.D4) m_keyboard.SetKey4(false);
            if (e.KeyCode == Keys.D0) m_keyboard.SetKey0(false);
            if (e.KeyCode == Keys.Y) m_keyboard.SetKeyY(false);
        }

        private Z80Lib.Context ctx;
        private Z80Lib.Z80 procX;
        private int xtot = 0;

        private XZ80Memory m_Xmem;


        private void button5_Click(object sender, EventArgs e)
        {
            LoopX(6000000);
        }
        public void LoopX(int steps)
        { 
            if (procX == null) {
                //var ctx = new Z80Lib.Context();
                var ctx = new Z80Lib.Context();

                //var mem = new XZ80Memory(m_zx); //copy
                m_Xmem = new XZ80Memory(m_zx); //copy
                var ports = new XInputOutput(m_keyboard); //?
                ctx.mem = m_Xmem;
                ctx.io = ports;

                //set up regs and pc as well?


                m_zx.CopyRegistersToXZ80(ref ctx);

                //var procX = new Z80Lib.Z80(ctx);
                procX = new Z80Lib.Z80(ctx);
            }

            //for (int i = 0; i < 6220003; i++)
            for (int i = 0; i < steps; i++)
                {
                    if (xtot == 0x2239ED)
                {
                    //Debugger.Break();
                }

                XStepMeansStep();
                m_zx.Step();

                bool theSame = m_zx.ComparetoXZ80(procX);
                string reason = "";
                if (!theSame) reason = m_zx.CompareAndGiveReason(procX);

                if (!theSame)
                {
                    Debugger.Break();
                }
                xtot++;
            }
            UpdateGUI();

        }
        private bool freshLDIR = true;
        private void XStepMeansStep()
        {
            bool resetToFreshLDIR = false;
            //also do a major do loop that handles LDIR
            bool over = true;
            do
            {
                over = true;
                do
                {
                    procX.Step();
                } while (procX.getContext().prefix != 0);
                //this completes our full instruction, or just one step of LDIR, in that case we will be back on the LDIR

                ushort pc = procX.getContext().pc.w;
                byte instr = procX.getContext().mem.Read(null, pc, false);
                byte instr2 = procX.getContext().mem.Read(null, (ushort)(pc + 1), false);
                if ((instr == 0xED) &&  ( (instr2 == 0xB0) || (instr2 == 0xB8))  )   //LDIR or LDDR
                {
                    if (freshLDIR)
                    {
                        freshLDIR = false;
                    }
                    else
                    {
                        //Debugger.Break();
                        over = false; //its not over
                        resetToFreshLDIR = true;
                    }
                }

            } while (!over);
            if (resetToFreshLDIR) freshLDIR = true;
        }



    }



    public class XZ80Memory : Z80Lib.IMemory
    {
        public XZ80Memory(Spectrum zz)
        {
            //create copy of memory
            ram = zz.CopyOfMemory();
        }
        public byte[] ram = new byte[65536];
        public byte Read(Z80Lib.Z80 cup, ushort adr, bool fuckYou)
        {
            return ram[adr];
        }
        public void Write(Z80Lib.Z80 cpu, ushort adr, byte value)
        {
            ram[adr] = value;
        }
    }
    public class XInputOutput : Z80Lib.IInputOutputPort
    {
        Keyboard m_kbd;
        public XInputOutput(Keyboard kbd)
        {
            m_kbd = kbd;
        }
        public byte Read(Z80Lib.Z80 cpu, ushort port)
        {
            byte rez = m_kbd.ReadForX(cpu.getContext().bc.b, cpu.getContext().bc.c);
            //Debugger.Break();
            //or read from keyboard
            //return 0x1F;
            return rez;
            //return (byte)(port >> 8);
        }
        public void Write(Z80Lib.Z80 cpu, ushort port, byte val)
        {
            //
            //Debugger.Break();
        }
    }

    public class Keyboard
    {
        private bool key1 = false;
        private bool key2 = false;
        private bool key3 = false;
        private bool key4 = false;

        private bool key0 = false;

        private bool keyY = false;
        private bool keySpace = false;
        private bool keyBreak = false;

        public bool key1pressed()
        {
            return key1;
        }
        public void SetKey1(bool s)
        {
            key1 = s;
        }
        public void SetKey2(bool s)
        {
            key2 = s;
        }
        public void SetKey3(bool s)
        {
            key3 = s;
        }
        public void SetKey4(bool s)
        {
            key4 = s;
        }


        internal void SetKey0(bool s)
        {
            key0 = s;
        }

        internal void SetKeyY(bool s)
        {
            keyY = s;
        }
        internal void SetKeySpace(bool s)
        {
            keySpace = s;
        }
        internal void SetKeyBreak(bool s)
        {
            keyBreak = s;
        }



        public bool ReadInPort(int b, int c, out byte a)
        {
            //read zx spectrum keys, only some combos of b and c will be valid
            if (c == 0xFE) //all key ports share this c
            {
                switch (b)
                {
                    case 0xF7:
                        if (key1)
                        {
                            a = 0x1E;  //all 5 bits on except the last (key 1)
                            a = 0b11110;
                            return true;
                        }
                        if (key2)
                        {
                            a = 0b11101; 
                            return true;
                        }
                        if (key3)
                        {
                            a = 0b11011;
                            return true;
                        }
                        if (key4)
                        {
                            a = 0b10111;
                            return true;
                        }
                        break;
                    case 0xEF:
                        if( key0)       
                        {
                            a = 0b11110;  //zero press
                            return true;
                        }
                        break;
                    case 0xDF:
                        if (keyY)
                        {
                            a = 0b01111;  //y press
                            return true;
                        }
                        break;
                    case 0x7F:
                        if (keySpace)
                        {
                            a = 0b11110;  
                            return true;
                        }
                        break;
                    case 0xFE:
                        if (keyBreak)
                        {
                            a = 0b11110;
                            return true;
                        }
                        break;

                }

            }
            //  bit 0     1   2 3 4 

            //FEFE  shift Z   X C V
            //FDFE  A     S   D F G
            //FBFE  Q     W   E R T
            //F7FE  1     2   3 4 5
            //EFFE  0     9   8 7 6
            //DFFE  P     O   I U Y
            //BFFE  enter L   K J H
            //7FFE  space Sym M N B

            a = 0;
            return false;

        }

        public byte ReadForX( int b, int c)
        {
            //reusing the same keyboard class for interpreter X
            //int b = cpu.getContext().bc.b;
            //int c = cpu.getContext().bc.c;

            byte rez;
            if (ReadInPort(b, c, out rez))
            {
                return rez;
            }


            return 0x1F; //5 keys all unpressed
        }



    }

    public class Screen
    {

        private Brush[] m_brushes = new Brush[]{
        Brushes.Black,
        new SolidBrush(Color.FromArgb(0,    (byte)0,    (byte)0xee)),
        new SolidBrush(Color.FromArgb(0xee, (byte)0,    (byte)0   )),
        new SolidBrush(Color.FromArgb(0xee, (byte)0,    (byte)0xee)),
        new SolidBrush(Color.FromArgb(0,    (byte)0xee, (byte)0   )),
        new SolidBrush(Color.FromArgb(0,    (byte)0xee, (byte)0xee)),
        new SolidBrush(Color.FromArgb(0xee, (byte)0xee, (byte)0   )),
        new SolidBrush(Color.FromArgb(0xee, (byte)0xee, (byte)0xee)),
    };
        private Brush[] m_brushes_bright = new Brush[]{
        Brushes.Black,
        new SolidBrush(Color.FromArgb(0,    (byte)0,    (byte)0xFF)),
        new SolidBrush(Color.FromArgb(0xFF, (byte)0,    (byte)0   )),
        new SolidBrush(Color.FromArgb(0xFF, (byte)0,    (byte)0xFF)),
        new SolidBrush(Color.FromArgb(0,    (byte)0xee, (byte)0   )),
        new SolidBrush(Color.FromArgb(0,    (byte)0xee, (byte)0xFF)),
        new SolidBrush(Color.FromArgb(0xFF, (byte)0xee, (byte)0   )),
        new SolidBrush(Color.FromArgb(0xFF, (byte)0xee, (byte)0xFF)),
    };
        
        private Color[] m_colors = new Color[]{
        Color.FromArgb(0,    (byte)0,    (byte)0   ),
        Color.FromArgb(0,    (byte)0,    (byte)0xee),
        Color.FromArgb(0xee, (byte)0,    (byte)0   ),
        Color.FromArgb(0xee, (byte)0,    (byte)0xee),
        Color.FromArgb(0,    (byte)0xee, (byte)0   ),
        Color.FromArgb(0,    (byte)0xee, (byte)0xee),
        Color.FromArgb(0xee, (byte)0xee, (byte)0   ),
        Color.FromArgb(0xee, (byte)0xee, (byte)0xee),
    };
        private Color[] m_colors_bright = new Color[]{
        Color.FromArgb(0,    (byte)0,    (byte)0   ),
        Color.FromArgb(0,    (byte)0,    (byte)0xFF),
        Color.FromArgb(0xFF, (byte)0,    (byte)0   ),
        Color.FromArgb(0xFF, (byte)0,    (byte)0xFF),
        Color.FromArgb(0,    (byte)0xee, (byte)0   ),
        Color.FromArgb(0,    (byte)0xee, (byte)0xFF),
        Color.FromArgb(0xFF, (byte)0xee, (byte)0   ),
        Color.FromArgb(0xFF, (byte)0xee, (byte)0xFF),
    };



        public void Paint4(Graphics g, byte[] ram)
        {
            //version 4, create memory bitmap, draw there.
            Bitmap pic = new Bitmap(256, 192, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Color cfore, cbackground;

            int screen_start = 16384 + 0;
            int attributes_start = 16384 + 256 * 192 / 8;

            for (int y = 0; y < 192; y++)
            {

                //get address y
                int adr;
                //adr = screen_start + y * 32;

                int third = y / 64;
                int char_row = y % 8;  //this is not row number counted in characters, but row inside a character
                int block_row = (y % 64) / 8;
                adr = screen_start + (third * 32 * 8 * 8) + (char_row * 256) + (block_row * 32);

                //attribute 
                int adr_attrib = attributes_start + (y / 8) * 32;

                for (int x = 0; x < 256; x += 8)
                {
                    int atrbyte = ram[adr_attrib];
                    bool bright = (atrbyte & 0x40) > 0;

                    if (bright)
                    {
                        //take 3 last bits
                        cfore = m_colors_bright[atrbyte % 8];
                        //take next 3 bits
                        cbackground = m_colors_bright[atrbyte / 8 % 8];


                    }
                    else
                    {

                        cfore = m_colors[atrbyte % 8];
                        cbackground = m_colors[atrbyte / 8 % 8];

                    }

                    byte bitmask = 128;
                    for (int i = 0; i < 8; i++)
                    {
                        int membyte = ram[adr];
                        if ((membyte & bitmask) > 0)
                        {
                            pic.SetPixel(x + i, y, cfore);
                        }
                        else
                        {
                            pic.SetPixel(x + i, y, cbackground);
                        }
                        bitmask = (byte)(bitmask >> 1);
                    }

                    adr++;
                    adr_attrib++;

                }
            }

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(pic, 0, 0, 256 * 3, 192 * 3);


        } //end Paint4







        public void Paint3(Graphics g, byte[] ram)
        {
            int PIX = 3;

            //version 3, create memory bitmap, draw there.

            Rectangle[] rects = new Rectangle[768];
            int rcount = 0;

            //new version, background will be drawn separately, to avoid drawing millions of background boxes
            Brush black = Brushes.Black;
            Brush fore;
            Brush background;

            int screen_start = 16384 + 0;
            int attributes_start = 16384 + 256 * 192 / 8;

            //draw attribs
            for (int y = 0; y < 24; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    int adr_attrib = attributes_start + (y / 8) * 32;
                    int atrbyte = ram[adr_attrib];
                    bool bright = (atrbyte & 0x40) > 0;
                    if (bright)
                    {
                        //take next 3 bits
                        background = m_brushes_bright[atrbyte / 8 % 8];
                    }
                    else
                    {
                        background = m_brushes[atrbyte / 8 % 8];
                    }
                    //draw 8 x 8 pixels box
                    rects[rcount++] = new Rectangle(8 * PIX * x, 8 * PIX * y, 8 * PIX, 8 * PIX);

                    //var drawer = void (Brush br) => g.FillRectangle(br, 8 * PIX * x, 8 * PIX * y, 8 * PIX, 8 * PIX);
                    //drawer(background);


                }
            }
            g.FillRectangles(m_brushes[0], rects);


            rects = new Rectangle[192 * 256];
            rcount = 0;


            for (int y = 0; y < 192; y++)
            {

                //get address y
                int adr;
                //adr = screen_start + y * 32;

                int third = y / 64;
                int char_row = y % 8;  //this is not row number counted in characters, but row inside a character
                int block_row = (y % 64) / 8;
                adr = screen_start + (third * 32 * 8 * 8) + (char_row * 256) + (block_row * 32);

                //attribute 
                int adr_attrib = attributes_start + (y / 8) * 32;


                for (int x = 0; x < 256; x += 8)
                {
                    int atrbyte = ram[adr_attrib];
                    bool bright = (atrbyte & 0x40) > 0;
                    if (bright)
                    {
                        //take 3 last bits
                        fore = m_brushes_bright[atrbyte % 8];
                        //take next 3 bits
                        background = m_brushes_bright[atrbyte / 8 % 8];
                    }
                    else
                    {
                        fore = m_brushes[atrbyte % 8];
                        background = m_brushes[atrbyte / 8 % 8];
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        int bitmask = (128 >> i);
                        int membyte = ram[adr];
                        //var drawer = br => { g.FillRectangle(br, 4 * (x + i), 4 * y, 4, 4); return 0};
                        //Action<Brush> drawer = br => { g.FillRectangle(br, 4 * (x + i), 4 * y, 4, 4);};
                        var drawer = void (Brush br) => g.FillRectangle(br, PIX * (x + i), PIX * y, PIX, PIX);
                        if ((membyte & bitmask) > 0)
                        {
                            //g.FillRectangle(black, x +i, y, 1, 1);
                            //g.FillRectangle(black, 2*(x + i), 2*y, 2, 2);

                            //g.FillRectangle(black, 4 * (x + i), 4 * y, 4, 4);
                            //g.FillRectangle(fore, 4 * (x + i), 4 * y, 4, 4);
                            //drawer(fore);

                            rects[rcount++] = new Rectangle(PIX * (x + i), PIX * y, PIX, PIX);
                            

                        }
                        else
                        {
                            //drawer(background); //moved to separate loop
                        }
                    }

                    adr++;
                    adr_attrib++;

                }
            }

            g.FillRectangles(m_brushes[7], rects);


        } //end Paint3





    }


}