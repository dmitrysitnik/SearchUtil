using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchSubStr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsCorrectFields())
            {
                SearchClass search = new SearchClass(Path.Text, SearchString.Text);
                search.Run(outputBox);
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
            
        }

        /// <summary>
        /// Проверка корректности полей
        /// </summary>
        /// <returns></returns>
        private bool IsCorrectFields()
        {
            if (String.IsNullOrEmpty(Path.Text) || String.IsNullOrEmpty(SearchString.Text))
            {
                return false;
            }
            return true;
        }
    }
}
