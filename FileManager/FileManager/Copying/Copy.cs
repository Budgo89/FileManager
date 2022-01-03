using FileManager.Assistant;
using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Copying
{
    public class Copy
    {
        private Form1 form; 
        private Rename rename;
        private bool copyBool = true;
        private Helper helper;
        private string copyFile;
        private string past;
        
        public Copy(Form1 form, Helper helper, Rename rename)
        {
            this.form = form;
            this.helper = helper;
            this.rename = rename;
        }
        public void CopyClic()
        {
            CopyStart();
        }
        public void InsertFileStartClic(string name)
        {
            rename.Close();
            InsertFileStart(name);
        }
        private void CopyStart()
        {
            if (copyBool == true)
            {
                copyBool = false;
                form.copy_button.Text = "Вставить";
                CopyFile();
            }
            else
            {
                copyBool = true;
                form.copy_button.Text = "Копировать";
                rename.Show();
            }
        }
        private void InsertFileStart(string name)
        {
            past = helper.Address();
            InsertFile(copyFile, Path.Combine(past, name));
            form.mainWindow.Refresh();
        }
        private void CopyFile()
        {
            copyFile = helper.PathAddress();
        }
        private void InsertFile(string copyDir, string endDir)
        {
            DirectoryInfo dirInf = new DirectoryInfo(copyDir);
            foreach (DirectoryInfo item in dirInf.GetDirectories())
            {
                if(Directory.Exists(endDir + "\\" + item.Name) != true)
                {                    
                    Directory.CreateDirectory(endDir + "\\" + item.Name);
                }
                InsertFile(item.FullName, endDir + '\\' + item.Name);
                foreach (string file in Directory.GetFiles(copyDir))
                {
                    string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                    File.Copy(file, endDir + "\\" + filik, true);
                }
            }            
        }
    }
}
