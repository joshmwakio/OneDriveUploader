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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            bunifuPanel1.BackgroundColor = colorDialog1.Color;
            bunifuLoader1.Color = colorDialog1.Color;
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
               
            }
            else if (bunifuDropdown1.SelectedIndex == 1)
            {
                bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dashed;
              
            }
            else if (bunifuDropdown1.SelectedIndex == 2)
            {
                bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dotted;
              

            }
            else
            {
                bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Diamond;
                
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLoader1.Speed = e.Value;
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLoader1.Thickness = e.Value;

        }

        private void bunifuHSlider3_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLoader1.DashWidth = e.Value;
        }
    }
}
