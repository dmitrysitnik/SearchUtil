using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SearchUtil.Classes
{
    class SearchClass
    {
        /// <summary>
        /// Константы для проверки атрибутов файла
        /// </summary>
        const string READ_ONLY = "ReadOnly";
        const string ARCHIVE = "Archive";
        const string HIDDEN = "Hidden";

        /// <summary>
        /// Путь к каталогу
        /// </summary>
        string path;

        /// <summary>
        /// Имя файла
        /// </summary>
        string filename;

        /// <summary>
        /// Требуется ли проверка атрибутов
        /// </summary>
        bool isNeedAttributesCheck;

        /// <summary>
        /// Требуется ли проверка подкаталогов
        /// </summary>
        bool allDirectories;

        /// <summary>
        /// Размер файла
        /// </summary>
        int sizeOfFile;

        /// <summary>
        /// Дата изменения файла
        /// </summary>
        DateTime dateOfChanging;


        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <param name="isNeedAttributesCheck"></param>
        /// <param name="allDirectories"></param>
        public SearchClass(string path, string filename, bool isNeedAttributesCheck, bool allDirectories, int sizeOfFile, DateTime date)
        {
            this.path = path;
            this.filename = filename;
            this.isNeedAttributesCheck = isNeedAttributesCheck;
            this.allDirectories = allDirectories;
            this.sizeOfFile = sizeOfFile;
            this.dateOfChanging = date;
        }

        /// <summary>
        /// Асинхронный метод для запуска поиска
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="hidden"></param>
        /// <param name="archive"></param>
        /// <returns></returns>
        public async Task<List<FileInfo>> Run(bool readOnly, bool hidden, bool archive)
        {
            return await SearchAsync(readOnly, hidden, archive);
        }

        /// <summary>
        /// Асинхронный метод поиска файлов
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="hidden"></param>
        /// <param name="archive"></param>
        /// <returns></returns>
        private Task<List<FileInfo>> SearchAsync( bool readOnly, bool hidden, bool archive)
        {
            return Task.Run(() => Search(readOnly, hidden, archive));
        }

        /// <summary>
        /// Поиск файлов
        /// </summary>
        /// <param name="readOnly"></param>
        /// <param name="hidden"></param>
        /// <param name="archive"></param>
        /// <returns></returns>
        private List<FileInfo> Search(bool readOnly, bool hidden, bool archive)
        {
            List<FileInfo> results = new List<FileInfo>();
            int count = 0;

            foreach (string foundFile in Directory.EnumerateFiles(path, filename, (allDirectories) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
            {
                count++;
                FileInfo FI;
                try
                {
                    FI = new FileInfo(foundFile);
                    if (FI.Length > sizeOfFile)
                    {
                        continue;
                    }

                    if (FI.LastWriteTime.Date != dateOfChanging)
                    {
                        continue;
                    }

                    if (isNeedAttributesCheck)
                    {
                        if (CheckAttributes(FI.Attributes.ToString(), readOnly, hidden, archive))
                        {
                            results.Add(FI);
                        }
                    }
                    else
                    {
                        results.Add(FI);
                    }
                }
                catch
                {
                    continue;
                }
            }
            return results;
        }

        /// <summary>
        /// Проверка атрибутов файла
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="readOnly"></param>
        /// <param name="hidden"></param>
        /// <param name="archive"></param>
        /// <returns></returns>
        private bool CheckAttributes(string attributes, bool readOnly, bool hidden, bool archive)
        {
            bool result = false;
            bool isHasAttribute;

            isHasAttribute = attributes.Contains(READ_ONLY);
            if (readOnly && isHasAttribute)
            {
                result = true;
            }
            else if(!readOnly && isHasAttribute)
            {
                return false;
            }

            isHasAttribute = attributes.Contains(HIDDEN);
            if (hidden && isHasAttribute)
            {
                result = true;
            }
            else if (!hidden && isHasAttribute)
            {
                return false;
            }

            isHasAttribute = attributes.Contains(ARCHIVE);
            if (archive && isHasAttribute)
            {
                result = true;
            }
            else if (!archive && isHasAttribute)
            {
                return false;
            }

            return result;
        }
    }

}
