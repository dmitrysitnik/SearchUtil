using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSubStr
{
    class SearchClass
    {
        /// <summary>
        /// Список найденных файлов
        /// </summary>
        public List<string> foundFiles = new List<string>();

        /// <summary>
        /// Путь к каталогу
        /// </summary>
        string path;

        /// <summary>
        /// Искомая строка
        /// </summary>
        string searchString;

        /// <summary>
        /// Конструктор класса SearchClass
        /// </summary>
        /// <param name="path"> Путь к каталогу</param>
        /// <param name="searchString"> Искомая подстрока</param>
        public SearchClass(string path, string searchString)
        {
            this.path = path;
            this.searchString = searchString;
        }

        /// <summary>
        /// Метод для запуска поиска и вывода найденных файлов
        /// </summary>
        /// <param name="rtb"> Объект RichTextBox для вывода</param>
        public void Run(RichTextBox rtb)
        {
            Search();
            PrintResults(rtb);            
        }

        /// <summary>
        /// Метод поиска файлов
        /// </summary>
        private void Search()
        {
            string file = "*.txt";
            string[] files;

            files = GetTxtFiles(file);
            for (int count = 0; count < files.Length; count++)
            {
                if(CheckFile(files[count]))
                {
                    foundFiles.Add(files[count]);
                }
            }
        }

        /// <summary>
        /// Получить текстовые файлы в каталоге
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string[] GetTxtFiles(string file)
        {
            string[] files = Directory.GetFiles(path, file);
            return files;
        }

        /// <summary>
        /// Проверить файл на наличие подстроки
        /// </summary>
        /// <returns></returns>
        private bool CheckFile(string file)
        {
            var fileLines = File.ReadAllLines(file);
            bool subStringFound = false;
            //var hashSet = new HashSet<string>(fileLines);
            foreach(string line in fileLines)
            {
                if (line.Contains(searchString))
                {
                    subStringFound = true;
                    break;
                }
            }
            return subStringFound;
        }


        /// <summary>
        /// Вывод найденых файлов 
        /// </summary>
        /// <param name="rtb"></param>
        private void PrintResults(RichTextBox rtb)
        {
            rtb.Clear();
            foreach(string file in foundFiles)
            {
                FileInfo FI;
                FI = new FileInfo(file);
                rtb.AppendText($"Имя файла:{FI.Name} Изменен: {FI.LastAccessTime}");
            }
            MessageBox.Show($"Всего найдено {foundFiles.Count} файлов");
        }

    }
}
