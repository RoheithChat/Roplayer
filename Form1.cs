using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = this.ClientSize - new System.Drawing.Size(axWindowsMediaPlayer1.Location);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void selectVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
            string video = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = video;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        
    }
}
