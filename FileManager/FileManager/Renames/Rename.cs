using FileManager.Assistant;
using FileManager.Forms;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Renames
{
    public class Rename
    {
        private Form1 form;
        private Helper helper;
        private RenameFileForms renameFileForms;
        public Rename(Form1 form, Helper helper, RenameFileForms renameFileForms)
        {
            this.form = form;
            this.helper = helper;
            this.renameFileForms = renameFileForms;
        }

        internal void RenameClick()
        {
            renameFileForms.Show();
        }

        internal void RenameStart()
        {
            RenameStarts();
        }
        private void RenameStarts()
        {
            var newName = renameFileForms.new_name.Text;
            var name = helper.Name();
            if (newName == name)
            {
                renameFileForms.error_text.Text = "Имя не должно совпадать";
            }
            else
            {
                if (File.Exists(helper.PathAddress()))
                {
                    FileSystem.RenameFile(helper.PathAddress(), newName);
                }
                else if (Directory.Exists(helper.PathAddress()))
                {
                    FileSystem.RenameDirectory(helper.PathAddress(), newName);
                }
                renameFileForms.Visible = false;
            }
            
        }
    }
}
