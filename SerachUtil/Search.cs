using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchUtil.Classes;
using System.IO;


namespace SearchUtil
{
    public partial class Form11 : Form
    {
        /// <summary>
        /// Тип интерфейса для определения dll к нашей программе
        /// </summary>
        const string SEARCH_PLUGIN = "SearchUtil.IPlugin";
        const string DLL_MASK = "*.dll";

        /// <summary>
        /// Загруженные dll's
        /// </summary>
        string[] dlls;

        /// <summary>
        /// delegate для работы с RichTextBox из другого потока
        /// </summary>
        /// <param name="text"></param>
        delegate void StringArgReturningVoidDelegate(String text);

        public Form11()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            if (IsFieldsCorrect())
            {
                outputBox.Clear();
                bool allDirectories = (CheckAllDir.Checked) ? true : false;
                SearchClass search = new SearchClass(pathInput.Text, Filename.Text, CheckAttr.Checked, allDirectories, Convert.ToInt32(FileSize.Text), Date.SelectionStart);
                List<FileInfo> foundFiles = await search.Run(cbReadOnly.Checked, cbHidden.Checked, cbArchive.Checked);
                await PrintResultsAsync(foundFiles, outputBox);
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
            
        }

        /// <summary>
        /// Вывод результатов. Асинхронный метод
        /// </summary>
        /// <param name="files"></param>
        /// <param name="rb"></param>
        /// <returns></returns>
        public Task PrintResultsAsync(List<FileInfo> files, RichTextBox rb)
        {
            return Task.Run(() =>
            {
                PrintResults(files, rb);
            });
        }

        /// <summary>
        /// Вывод результатов
        /// </summary>
        /// <param name="files"></param>
        /// <param name="rb"></param>
        public void PrintResults(List<FileInfo> files, RichTextBox rb)
        {
            int count = 0;
            foreach (FileInfo fi in files)
            {
                count++;
                AddText($"{ count}.Имя файла:{ fi.Name} Дата последнего изменения: { fi.LastWriteTime}\n");
            }
            MessageBox.Show($"Всего найдено {count} файлов");
        }


        /// <summary>
        /// Метод для добавления текста в RichTextBox из другого потока
        /// </summary>
        /// <param name="text"></param>
        private void AddText(string text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.outputBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AddText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.outputBox.AppendText(text);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ///Выполним загрузку плагинов при активации формы
            ///(был добавлен новый плагин и программа вновь развернута)
            LoadPlugins();
            if (!CheckAttr.Checked)
            {
                cbReadOnly.Visible = false;
                cbHidden.Visible = false;
                cbArchive.Visible = false;
            }
        }
        
        /// <summary>
        /// Учитывать атрибуты при поиске
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadOnly.Visible && cbArchive.Visible && cbHidden.Visible)
            {
                cbReadOnly.Visible = false;
                cbHidden.Visible = false;
                cbArchive.Visible = false;
            }
            else
            {
                cbReadOnly.Visible = true;
                cbHidden.Visible = true;
                cbArchive.Visible = true;
            }
        }

        /// <summary>
        /// Метод для загрузки плагинов, разработанных для нашей программы
        /// </summary>
        private void LoadPlugins()
        {
            string sPath = Application.StartupPath;
            List<IPlugin> lPlugins = new List<IPlugin>();
                foreach (string f in Directory.GetFiles(sPath, DLL_MASK))
                {
                if (dlls != null)
                {
                    if (dlls.Contains(f))
                    {
                        continue;
                    }
                }
                System.Reflection.Assembly a = System.Reflection.Assembly.LoadFile(f);
                    foreach (Type t in a.GetTypes())
                    {
                        foreach (Type i in t.GetInterfaces())
                        {
                            if (i.Equals(Type.GetType(SEARCH_PLUGIN)))
                            {
                                
                                IPlugin p = (IPlugin)Activator.CreateInstance(t);
                                lPlugins.Add(p);
                                p.Initialize(this);
                                break;
                            }
                        }
                    }
                }
                //Сохранить последние загруженные библиотеки
                dlls = Directory.GetFiles(sPath, DLL_MASK);
        }

        /// <summary>
        /// Выполнить загрузку плагинов при старте программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        /// <summary>
        /// Проверить заполнены ли поля..
        /// </summary>
        /// <returns></returns>
        private bool IsFieldsCorrect()
        {
            if(String.IsNullOrEmpty(pathInput.Text) || String.IsNullOrEmpty(FileSize.Text) || String.IsNullOrEmpty(Filename.Text))
            {
                return false;
            }
            return true;
        }
    }
}
