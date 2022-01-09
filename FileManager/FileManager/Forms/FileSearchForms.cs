using FileManager.Assistant;
using FileManager.FileSearchs;
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
    public partial class FileSearchForms : Form
    {
        private FileSearch fileSearch;
        private Helper helper;
        public FileSearchForms()
        {
            InitializeComponent();
        }
        public void FileSearchAdd(FileSearch fileSearch, Helper helper)
        {
            this.fileSearch = fileSearch;
            this.helper = helper;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            fileSearch.FileSearchClick(helper.Address(), maska_text.Text);
        }
    }
}
