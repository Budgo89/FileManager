using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Assistant
{
    public class Helper
    {
        private Form1 form;
        public Helper(Form1 form)
        {
            this.form = form;
        }
        public string Address()
        {
            return form.fileAddress.Text;
        }

        public string Name()
        {
            return form.mainWindow.SelectedItem.ToString();
        }
        public string PathAddress()
        {
            string fileAddress = form.fileAddress.Text;
            if (form.mainWindow.SelectedItem.ToString() != null)
            {
                string mainWindow = form.mainWindow.SelectedItem.ToString();
                return Path.Combine(fileAddress, mainWindow);
            }
            else return null;
            
        }
    }
}
