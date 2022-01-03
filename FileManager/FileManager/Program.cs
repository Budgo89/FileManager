using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Display;
using FileManager.Forms;
using FileManager.Transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            var renameForm = new Rename();
            var deleteForms = new DeleteForms();

            var helper = new Helper(form);            
            var displayAssistant = new DisplayAssistant(form);
            var folderWalking = new FolderWalking(displayAssistant);
            var copy = new Copy(form, helper, renameForm);
            var delete = new Delete(form, helper, deleteForms);
            form.Form1AddFolderWalking(folderWalking, helper, copy, delete);
            renameForm.RenameAdd(copy);
            deleteForms.DeleteFormsAdd(delete);
            Application.Run(form);
        }
    }
}
