using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Display;
using FileManager.Forms;
using FileManager.Renames;
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
            var renameForms = new RenameForms();
            var deleteForms = new DeleteForms();
            var renameFileForms = new RenameFileForms();

            var helper = new Helper(form);            
            var displayAssistant = new DisplayAssistant(form);
            var folderWalking = new FolderWalking(displayAssistant);
            var copy = new Copy(form, helper, renameForms);
            var delete = new Delete(form, helper, deleteForms);
            var rename = new Rename(form,helper,renameFileForms);
            form.Form1AddFolderWalking(folderWalking, helper, copy, delete, rename);
            renameForms.RenameAdd(copy);
            deleteForms.DeleteFormsAdd(delete);
            renameFileForms.RenameFileFormsAdd(rename);
            Application.Run(form);
        }
    }
}
