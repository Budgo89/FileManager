using FileManager.Assistant;
using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Сreates
{
    public class Create
    {
        private CreateForms createForm;
        private Helper helper;
        public Create(CreateForms createForm, Helper helper)
        {
            this.createForm = createForm;
            this.helper = helper;
        }

        public void CreateClick()
        {
            CreateStart();    
        }
        internal void CreateStart(string name)
        {
            createForm.Visible = false;
            CreateСheck(name);
        }

        private void CreateСheck(string name)
        {
            if (СheckFile(name))
            {
                File.Create(Path.Combine(helper.Address(), name));
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(helper.Address(), name));
            }
        }
        private void CreateStart()
        {
            createForm.Show();
        }
        private bool СheckFile(string name)
        {
            char[] nameChar = name.ToCharArray();
            foreach (var item in nameChar)
            {
                if (item == '.')
                {
                    return true;
                }
            }
            return false;
        }

    }
}
