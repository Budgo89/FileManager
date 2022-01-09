using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Information
{
    internal class ScannerFile
    {
        public int WordCountStart(string address)
        {
            var count = WordCount(address) + 1;
            return count;
        }
        public int NumberOfParagraphsStart(string address)
        {
            return NumberOfParagraphs(address);
        }
        public int NumberOfCharactersStart(string address)
        {
            return NumberOfCharacters(address);
        }

        private int NumberOfCharacters(string address)
        {
            int charCount = 0;
            using (var streamReader = new StreamReader(
                new BufferedStream(
                    File.OpenRead(address), 10 * 1024 * 1024)))
            {
                while (streamReader.Read() > -1)
                {
                    charCount++;
                }
                return charCount;
            }
        }

        private int WordCount(string address)
        {
            try
            {
                string text = "";
                string[] textMass;
                int count = 0;
                using (StreamReader streamReader = new StreamReader(address))
                {
                    while (streamReader.EndOfStream != true)
                    {
                        text += streamReader.ReadLine();
                    }
                    textMass = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    count = textMass.Length;
                    return count;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private int NumberOfParagraphs(string address)
        {
            var linesCount = 0;
            int nextLine = '\n';
            using (var streamReader = new StreamReader(
                new BufferedStream(
                    File.OpenRead(address), 10 * 1024 * 1024))) // буфер в 10 мегабайт
            {
                while (!streamReader.EndOfStream)
                {
                    if (streamReader.Read() == nextLine) linesCount++;
                }
                return linesCount;
            }
        }
    }
}
