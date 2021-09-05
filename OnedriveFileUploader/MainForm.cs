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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            DialogResult result=form.ShowDialog();
            if (result == DialogResult.OK)
            {
                await Task.Delay(500);
                bunifuTransition1.Hide(form, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Particles);
                bunifuSnackbar1.Show(this, "Files Uploaded Successfully", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 3000,null,Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                bunifuProgressBar6.ValueByTransition = 100;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
