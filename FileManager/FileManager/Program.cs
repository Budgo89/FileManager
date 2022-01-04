using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Display;
using FileManager.Forms;
using FileManager.Renames;
using FileManager.Transferals;
using FileManager.Transitions;
using FileManager.Сreates;
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
            var createForm = new CreateForm();

            var helper = new Helper(form);            
            var displayAssistant = new DisplayAssistant(form);
            var folderWalking = new FolderWalking(displayAssistant);
            var copy = new Copy(form, helper, renameForms);
            var delete = new Delete(form, helper, deleteForms);
            var rename = new Rename(form,helper,renameFileForms);
            var transferal = new Transferal(form, helper, copy, delete);
            var create = new Create(createForm, helper);
            form.Form1AddFolderWalking(folderWalking, helper, copy, delete, rename, transferal, create);
            renameForms.RenameAdd(copy);
            deleteForms.DeleteFormsAdd(delete);
            renameFileForms.RenameFileFormsAdd(rename);
            createForm.CreateFormAdd(create);
            Application.Run(form);
        }
    }
}
