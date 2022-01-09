using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Forms;
using FileManager.Information;
using FileManager.Renames;
using FileManager.Transferals;
using FileManager.Transitions;
using FileManager.Сreates;
using System;
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
        private Rename rename;
        private Transferal transferal;
        private Create create;
        private Info info;
        private FileSearchForms fileSearchForms;
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1AddFolderWalking(FolderWalking folderWalking, Helper helper, Copy copy, Delete delete, Rename rename, Transferal transferal, Create create, Info info, FileSearchForms fileSearchForms)
        {
            this.folderWalking = folderWalking;
            this.helper = helper;
            this.copy = copy;
            this.delete = delete;
            this.rename = rename;
            this.transferal = transferal;
            this.create = create;
            this.info = info;
            this.fileSearchForms = fileSearchForms;
        }

        private void goOver_button_Click(object sender, EventArgs e)
        {
            mainWindow.Items.Clear();
            addres = helper.Address();
            folderWalking.GoOverStart(addres);
        }

        private void mainWindow_doudleClick(object sender, MouseEventArgs e)
        {
            addres = helper.PathAddress();
            fileAddress.Text = addres;
            mainWindow.Items.Clear();
            folderWalking.GoOverStart(addres);
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            copy.CopyClick();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete.DeleteClick();
        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            rename.RenameClick();
        }

        private void transferal_button_Click(object sender, EventArgs e)
        {
            transferal.TransferalClick();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            create.CreateClick();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            info.infoClick();
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            mainWindow.Items.Clear();
            folderWalking.GoBackClick();
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            fileSearchForms.Show();
        }
    }
}
