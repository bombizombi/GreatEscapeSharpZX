using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatEscape
{
    public partial class FormMemoryAccessChart : Form
    {
        public  FormMemoryAccessChart()
        {
            InitializeComponent();
        }

        MemoryAccessVisualizer m_viz;
        public FormMemoryAccessChart(MemoryAccessVisualizer vis) : this()
        {
            m_viz = vis;
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            m_viz.Paint(e.Graphics);
        }

        private void FormMemoryAccessChart_Load(object sender, EventArgs e)
        {
            //this.Location.X = 2000;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            m_viz.PaintMemAccess(e.Graphics);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            m_viz.m_zx.ClearLines();
            pictureBoxLines.Invalidate();
        }
    }
}
