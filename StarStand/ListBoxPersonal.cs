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
    public partial class ListBoxPersonal : UserControl
    {
        public event EventHandler ChangeSeletedIndex;
        public string titulo
        {
            get { return lblSetText.Text; }
            set { lblSetText.Text = value; }
        }
        public Color bgColorHead
        {
            get { return panelHead.BackColor; }
            set { panelHead.BackColor = value; }
        }

        public Color titleColor
        {
            get { return lblSetText.ForeColor; }
            set { lblSetText.ForeColor = value; }
        }
        public Color bgcolorList
        {
            get { return list.BackColor; }
            set { list.BackColor = value; }
        }
        public ListBoxPersonal()
        {
            InitializeComponent();
            this.list.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChangeSeletedIndex != null)
            {
                ChangeSeletedIndex(sender, e);
            }
        }
    }
}
