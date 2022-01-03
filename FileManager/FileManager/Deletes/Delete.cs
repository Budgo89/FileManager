using FileManager.Assistant;
using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Deletes
{
    public class Delete
    {
        private Form1 form;
        private Helper helper;
        private DeleteForms deleteForms;
        public Delete(Form1 form, Helper helper, DeleteForms deleteForms)
        {
            this.form = form;
            this.helper = helper;
            this.deleteForms = deleteForms;
        }

        internal void DeleteClick()
        {
            deleteForms.Show();
        }

        internal void DeleteYes()
        {
            DeleteStart();
        }

        private void DeleteStart()
        {
            var file = helper.PathAddress();
            if (helper.Name() != "" || helper.Name() != null)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                else Directory.Delete(file, true);
            }            
        }
    }
}
