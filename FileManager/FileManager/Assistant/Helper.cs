using System.IO;

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
            if (form.mainWindow.SelectedItem != null)
            {
                return form.mainWindow.SelectedItem.ToString();
            }
            return null;
        }
        public string PathAddress()
        {
            string fileAddress = form.fileAddress.Text;
            if (Name() != null)
            {
                string mainWindow = form.mainWindow.SelectedItem.ToString();
                return Path.Combine(fileAddress, mainWindow);
            }
            else return null;            
        }
    }
}
