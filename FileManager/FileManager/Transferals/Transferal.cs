using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Transferals
{
    public class Transferal
    {
        private Form1 form;
        private Helper helper;
        private Copy copy;
        private Delete delete;
        private bool transferalBool = true;
        private string address;
        private string name;
        public Transferal(Form1 form, Helper helper, Copy copy, Delete delete)
        {
            this.form = form;
            this.helper = helper;
            this.copy = copy;
            this.delete = delete;
        }
        public void TransferalClick()
        {
            TransferalStart();
        }

        private void TransferalStart()
        {
            if (transferalBool == true)
            {
                address = helper.PathAddress();
                name = helper.Name();
                transferalBool = false;
                form.transferal_button.Text = "Вставить";
                //form.transferal_button.Enabled = false;
                //copy.CopyTransferalClick();
            }
            else
            {
                transferalBool = true;
                form.transferal_button.Text = "Переместить";
                copy.CopyTransferalClick(name,address);
                delete.DeleteYes(address);
            }
        }
    }
}
