using FileManager.Copying;
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
    public partial class RenameForms : Form
    {
        private Copy copy;
        public RenameForms()
        {
            InitializeComponent();
        }
        public void RenameAdd(Copy copy)
        {
            this.copy = copy;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            var text = rename_textBox.Text;
            if (text != null)
            {
                copy.InsertFileStartClic(text);
            }
            
        }
    }
}
