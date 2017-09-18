using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using System.Windows.Forms;

namespace WordAttributes
{
    class SearchClass
    {
        /// <summary>
        /// Путь к каталогу
        /// </summary>
        string path;

        /// <summary>
        /// Имя компании
        /// </summary>
        string companyName;

        /// <summary>
        /// Количество символов
        /// </summary>
        int countOfCharacters;

        /// <summary>
        /// Количество строк
        /// </summary>
        int lines;

        /// <summary>
        /// Руководитель
        /// </summary>
        string manager;

        /// <summary>
        /// Шаблон документа Word
        /// </summary>
        string template;

        /// <summary>
        /// Список найденных файлов
        /// </summary>
        List<string> foundFiles = new List<string>();


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path"></param>
        /// <param name="company"></param>
        /// <param name="countOfCharacters"></param>
        /// <param name="lines"></param>
        /// <param name="manager"></param>
        /// <param name="template"></param>
        public SearchClass(string path, string company, int countOfCharacters, int lines, string manager, string template)
        {
            this.path = path;
            this.companyName = company;
            this.lines = lines;
            this.manager = manager;
            this.countOfCharacters = countOfCharacters;
            this.template = template;
        }

        /// <summary>
        /// Публичный метод для запуска поиска
        /// </summary>
        /// <param name="rtb"></param>
        public void Run(RichTextBox rtb)
        {
            Search();
            PrintResults(rtb);
        }


        /// <summary>
        /// Метод для поиска docx файлов
        /// </summary>
        private void Search()
        {
            const string FILE= "*.docx";
            string[] files;

            files = GetDocFiles(FILE);
            for (int count = 0; count < files.Length; count++)
            {
                if (IsSuitableFile(files[count]))
                {
                    foundFiles.Add(files[count]);
                }
            }
        }

        /// <summary>
        /// Получить файлы из каталога
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string[] GetDocFiles(string file)
        {
            string[] files = Directory.GetFiles(path, file);
            return files;
        }

        /// <summary>
        /// Проверка свойств файла
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private bool IsSuitableFile(string file)
        {
            using (WordprocessingDocument document =
                WordprocessingDocument.Open(file, false))
            {
                var props = document.ExtendedFilePropertiesPart.Properties;

                if (props.Manager.Text != manager)
                {
                    return false;
                }

                if (props.Company.Text != companyName)
                {
                    return false;
                }

                if (Convert.ToInt32(props.Lines.Text) > lines)
                {
                    return false;
                }

                if (Convert.ToInt32(props.Characters.Text) > countOfCharacters)
                {
                    return false;
                }

                if (props.Template.Text != template)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Вывод результатов
        /// </summary>
        /// <param name="rtb"></param>
        private void PrintResults(RichTextBox rtb)
        {
            rtb.Clear();
            foreach (string file in foundFiles)
            {
                FileInfo FI;
                FI = new FileInfo(file);
                rtb.AppendText($"Имя файла:{FI.Name} Изменен: {FI.LastAccessTime}");
            }
            MessageBox.Show($"Всего найдено {foundFiles.Count} файлов");
        }

    }
}
