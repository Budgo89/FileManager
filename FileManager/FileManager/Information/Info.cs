using FileManager.Assistant;
using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Information
{
    public class Info
    {
        private InfoForms infoForms;
        private Helper helper;

        public Info(InfoForms infoForms, Helper helper)
        {
            this.infoForms = infoForms;
            this.helper = helper;
        }

        public void infoClick()
        {
            DetailСheck();
            InfoStart();
        }

        private void DetailСheck()
        {
            var extension = Path.GetExtension(helper.PathAddress());
            if (extension == ".txt")
            {
                infoForms.detail_button.Visible = true;
            }
            else infoForms.detail_button.Visible = false;
        }

        private void InfoStart()
        {
            if (helper.Name() != null)
            {                
                infoForms.Show();
                var file = helper.PathAddress();
                infoForms.name_file.Text = helper.Name();
                if (Directory.Exists(file))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(file);
                    infoForms.label1_1.Text = GetDirectorySize(file).ToString();
                    infoForms.label2.Text = "Кол-во папок:";
                    infoForms.label2_1.Text = directoryInfo.GetDirectories().Length.ToString();
                    infoForms.label3.Text = "Кол-во файлов:";
                    infoForms.label3_1.Text = directoryInfo.GetFiles().Length.ToString();
                }
                else if (File.Exists(file))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    infoForms.label1_1.Text = fileInfo.Length.ToString();
                    infoForms.label2.Text = "Расширение";
                    infoForms.label2_1.Text = fileInfo.Extension.ToString();
                    infoForms.label3.Text = "";
                    infoForms.label3_1.Text = "";

                }
            }
        }

        public static long GetDirectorySize(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] subdirectories = Directory.GetDirectories(path);

            long size = files.Sum(x => new FileInfo(x).Length);
            foreach (string s in subdirectories)
                size += GetDirectorySize(s);

            return size;
        }
    }
}
