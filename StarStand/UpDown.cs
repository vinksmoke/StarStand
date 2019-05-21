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
    public partial class UpDown : UserControl
    {
        public UpDown()
        {
            InitializeComponent();
        }

        private void TextBoxValue_Leave(object sender, EventArgs e)
        {
            float num;
            if (!float.TryParse(textBoxValue.Text,out num))
            {
                MessageBox.Show("Os numero nao é real");
            }
        }
    }
}
