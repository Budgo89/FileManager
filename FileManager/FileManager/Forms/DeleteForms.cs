using FileManager.Deletes;
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
    public partial class DeleteForms : Form
    {
        private Delete delete;
        public DeleteForms()
        {
            InitializeComponent();
        }
        public void DeleteFormsAdd(Delete delete)
        {
            this.delete = delete;
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            Visible = false;
            delete.DeleteYes();
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
