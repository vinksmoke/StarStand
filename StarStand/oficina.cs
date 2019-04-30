using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarStand
{
    public partial class oficina : UserControl
    {
        public oficina()
        {
            InitializeComponent();
        }

        private void BunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void ListBoxPersonal2_Load(object sender, EventArgs e)
        {
            
        }

        public void placeholder(TextBox textbox, string textToPlaceHolder)
        {
            if (textbox.Text == "")
            {
                textbox.Text = textToPlaceHolder;
            }
            if (textbox.Text == textToPlaceHolder)
            {
                textbox.Text = "";
            }
        }
    }
}
