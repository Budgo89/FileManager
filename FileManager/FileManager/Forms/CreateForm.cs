using FileManager.Сreates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Forms
{
    public partial class CreateForm : Form
    {
        private Create create;
        public CreateForm()
        {
            InitializeComponent();
        }
        public void CreateFormAdd(Create create)
        {
            this.create = create;
        }
        private void ok_button_Click(object sender, EventArgs e)
        {
            create.CreateStart(name_textBox.Text);
        }
    }
}
