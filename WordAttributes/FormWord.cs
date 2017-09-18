using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordAttributes
{
    public partial class FormWord : Form
    {
        public FormWord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запуск процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFieldsCorrect())
            {
                SearchClass search = new SearchClass(Path.Text, CompanyName.Text, Convert.ToInt32(Characters.Text), Convert.ToInt32(Lines.Text), Manager.Text, Template.Text);
                search.Run(outputBox);
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        /// <summary>
        /// Проврка полей на заполненность
        /// </summary>
        /// <returns></returns>
        private bool isFieldsCorrect()
        {
            if (String.IsNullOrEmpty(Path.Text) || String.IsNullOrEmpty(Template.Text) || String.IsNullOrEmpty(Lines.Text) || String.IsNullOrEmpty(Characters.Text) || String.IsNullOrEmpty(Manager.Text))
            {
                return false;
            }
            return true;
        }
    }
}
