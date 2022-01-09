using FileManager.Assistant;
using FileManager.Display;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Transitions
{
    public class FolderWalking
    {
        private DisplayAssistant displayAssistant;
        private Helper helper;
        private Stack<string> back;
        private Form1 form;

        public FolderWalking(DisplayAssistant displayAssistant, Helper helper, Form1 form)
        {
            this.displayAssistant = displayAssistant;
            this.helper = helper;
            this.form = form;
            back = new Stack<string>();
        }

        public void GoOverStart(string directory)
        {
            if (directory != null)
            {
                if (Directory.Exists(directory))
                {
                    back.Push(directory);
                    GoOverDirectory(directory);
                    GoOverFile(directory);
                }
            }
        }
        private void GoOverFile(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);               
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            displayAssistant.FileDisplay(fileInfos);
        }

        private void GoOverDirectory(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            displayAssistant.DirectoryDisplay(directoryInfos);
            
        }

        public void GoBackClick()
        {
            GoBackStart();
        }
        private void GoBackStart()
        {
            if (back.Count != 0)
            {
                var backClick = back.Pop();
                form.fileAddress.Text = backClick;
                GoOverDirectory(backClick);
                GoOverFile(backClick);
            }

        }
    }
}
