using FileManager.Assistant;
using FileManager.Copying;
using FileManager.Deletes;
using FileManager.Display;
using FileManager.FileSearchs;
using FileManager.Forms;
using FileManager.Information;
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
            var createForm = new CreateForms();
            var infoForms = new InfoForms();
            var detailForms = new DetailForms();
            var fileSearchForms = new FileSearchForms();

            var helper = new Helper(form);            
            var displayAssistant = new DisplayAssistant(form);
            var folderWalking = new FolderWalking(displayAssistant, helper, form);
            var copy = new Copy(form, helper, renameForms);
            var delete = new Delete(form, helper, deleteForms);
            var rename = new Rename(form,helper,renameFileForms);
            var transferal = new Transferal(form, helper, copy, delete);
            var create = new Create(createForm, helper);
            var info = new Info(infoForms, helper);
            var detailInfo = new DetailInfo(detailForms, helper);
            var fileSearch = new FileSearch(fileSearchForms);
            form.Form1AddFolderWalking(folderWalking, helper, copy, delete, rename, transferal, create, info, fileSearchForms);
            renameForms.RenameAdd(copy);
            deleteForms.DeleteFormsAdd(delete);
            renameFileForms.RenameFileFormsAdd(rename);
            createForm.CreateFormAdd(create);
            infoForms.InfoFormsAdd(detailInfo);
            fileSearchForms.FileSearchAdd(fileSearch, helper);
            Application.Run(form);
        }
    }
}
