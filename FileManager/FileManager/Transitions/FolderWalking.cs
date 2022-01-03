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

        public FolderWalking(DisplayAssistant displayAssistant)
        {
            this.displayAssistant = displayAssistant;
        }

        public void goOverDirectoryClic(string directory)
        {
            goOverDirectory(directory);
        }
        public void goOverFileClic(string directory)
        {
            goOverFile(directory);
        }

        private void goOverFile(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            displayAssistant.FileDisplay(fileInfos);
        }

        private void goOverDirectory(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            displayAssistant.DirectoryDisplay(directoryInfos);
        }

    }
}
