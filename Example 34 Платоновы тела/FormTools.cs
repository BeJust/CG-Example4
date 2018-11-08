using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_34_Платоновы_тела
{
    public partial class FormTools : Form
    {
        public FormTools()
        {
            InitializeComponent();
        }

        private void FormTools_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(w - this.Width, 20);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            byte flBody = Convert.ToByte((sender as RadioButton).Tag);
            PlatonBody.body = new Body(flBody);
            FormMain.MyDraw();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = false;
            FormMain.MyDraw();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = true;
            FormMain.MyDraw();
        }
        
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PlatonBody.Sv[0] = hScrollBar1.Value / 30d;
            FormMain.MyDraw();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            PlatonBody.Sv[1] = hScrollBar2.Value / 30d;
            FormMain.MyDraw();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            PlatonBody.Sv[2] = 1.5 + hScrollBar3.Value / 100d;
            FormMain.MyDraw();
        }
    }
}
