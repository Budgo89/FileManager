using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileManager.FileSearchs
{
    public class FileSearch
    {

        private List<string> tStrings;
        private FileSearchForms fileSearchForms;

        public FileSearch(FileSearchForms fileSearchForms)
        {
            this.fileSearchForms = fileSearchForms;
            tStrings = new List<string>();
        }

        public void FileSearchClick(string address, string mask)
        {
            tStrings.Clear();
            _=FileSearchStart(address, mask);
            FileSearchPrint();
        }

        private void FileSearchPrint()
        {
            fileSearchForms.search_results_listBox.Items.Clear();
            foreach (var item in tStrings)
            {
                if (item != null)
                {
                    fileSearchForms.search_results_listBox.Items.Add(item);
                }
            }
        }

        private string[] FileSearchStart(string address, string mask)
        {
            string[] files = Directory.GetFiles(address);
            string[] subdirectories = Directory.GetDirectories(address);
            string[] size;
            foreach (var item in files)
            {
                if (Regex.IsMatch(Path.GetFileName(item), mask))
                {
                    tStrings.Add(item);
                }
            }
            
            foreach (string s in subdirectories)
            {
                size = FileSearchStart(s, mask);
                foreach (var item in size)
                {
                    tStrings.Add(item);
                }
                if (Regex.IsMatch(Path.GetDirectoryName(s), mask))
                {
                    tStrings.Add(s);
                }
            }
            size = new string[2];
            return size;
        }
    }

}
