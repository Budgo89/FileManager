using FileManager.Information;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Forms
{
    public partial class InfoForms : Form
    {
        private DetailInfo detailInfo;
        public InfoForms()
        {
            InitializeComponent();
        }
        public void InfoFormsAdd(DetailInfo detailInfo)
        {
            this.detailInfo = detailInfo;
        }

        private void ok_info_button_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void detail_button_Click(object sender, EventArgs e)
        {
            detailInfo.DetailClick();
        }
    }
}
