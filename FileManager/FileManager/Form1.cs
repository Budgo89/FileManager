using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Transitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private FolderWalking folderWalking;
        private string addres;
        private Helper helper;
        private Copy copy;
        private Delete delete;
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1AddFolderWalking(FolderWalking folderWalking, Helper helper, Copy copy, Delete delete)
        {
            this.folderWalking = folderWalking;
            this.helper = helper;
            this.copy = copy;
            this.delete = delete;
        }

        private void goOver_button_Click(object sender, EventArgs e)
        {
            mainWindow.Items.Clear();
            addres = helper.Address();
            folderWalking.goOverDirectoryClic(addres);
            folderWalking.goOverFileClic(addres);
        }

        private void mainWindow_doudleClick(object sender, MouseEventArgs e)
        {
            addres = helper.PathAddress();
            fileAddress.Text = addres;
            mainWindow.Items.Clear();
            folderWalking.goOverDirectoryClic(addres);
            folderWalking.goOverFileClic(addres);
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            copy.CopyClic();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete.DeleteClick();
        }
    }
}
