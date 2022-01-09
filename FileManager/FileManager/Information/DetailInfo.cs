using FileManager.Assistant;
using FileManager.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Information
{
    public class DetailInfo
    {
        private DetailForms detailForms;
        private Helper helper;

        public DetailInfo(DetailForms detailForms, Helper helper)
        {
            this.detailForms = detailForms;
            this.helper = helper;
        }

        internal void DetailClick()
        {
            DetailStart();
        }

        private void DetailStart()
        {
            detailForms.Show();
            detailForms.extension_text.Text = Path.GetExtension(helper.PathAddress());
            detailForms.number_of_lines_text.Text = File.ReadAllLines(helper.PathAddress()).Length.ToString();
            var scannerFile = new ScannerFile();
            detailForms.number_of_paragraphs_text.Text = scannerFile.NumberOfParagraphsStart(helper.PathAddress()).ToString();
            detailForms.number_of_words_text.Text = scannerFile.WordCountStart(helper.PathAddress()).ToString();
            detailForms.number_of_characters_text.Text = scannerFile.NumberOfCharactersStart(helper.PathAddress()).ToString();
        }
    }
}
