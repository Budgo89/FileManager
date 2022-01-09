using System.IO;

namespace FileManager.Display
{
    public class DisplayAssistant
    {
        private Form1 form;
        public DisplayAssistant(Form1 form)
        {
            this.form = form;
        }
        public void DirectoryDisplay(DirectoryInfo[] directoryInfos)
        {
            DisplayingDirectorysInWindow(directoryInfos);
        }
        public void FileDisplay(FileInfo[] fileInfos)
        {
            DisplayingFilesInWindow(fileInfos);
        }
        private void DisplayingDirectorysInWindow(DirectoryInfo[] directoryInfos)
        {            
            foreach (var item in directoryInfos)
            {                
                form.mainWindow.Items.Add(item);
            }
        }

        internal void DisplayingFilesInWindow(FileInfo[] fileInfos)
        {
            foreach (var item in fileInfos)
            {
                form.mainWindow.Items.Add(item);
            }
        }
    }
}
