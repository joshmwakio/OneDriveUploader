using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderDoc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int totalFiles = 35;
        int uploadedFiles = 0;
        public DialogResult Result { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int speed = random.Next(200, 421);
            if (uploadedFiles < 35)
            {
                uploadedFiles += 1;
                bunifuLabel3.Text = String.Format("{0}/{1} files uploaded to One Drive ({2} kb/s)",uploadedFiles,totalFiles,speed);
            }
            if (uploadedFiles == 35)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                Result=DialogResult.OK;               
            }
           
        }
    }
}
