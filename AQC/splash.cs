using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AQC_Manager
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

            timer1.Start();
            


           // mainWindow MainWindow = new mainWindow();
           // MainWindow.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBAR.Increment(1);
            if (prgBAR.Value == 100)
            {
                timer1.Stop();
            }

        }

        //private void btn_close_Click(object sender, EventArgs e)
        //{
        //    mainWindow MainWindow = new mainWindow();
        //    MainWindow.Show();

        //    this.Hide();
        //}
    }
}
