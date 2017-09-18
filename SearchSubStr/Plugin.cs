using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchUtil;

namespace SearchSubStr
{
    public class Plugin : IPlugin
    {
        /// <summary>
        /// Название Plug-in'a
        /// </summary>
        public string name
        {
            get { return "SearchSubString"; }
        }

        /// <summary>
        /// Version
        /// </summary>
        public Version version
        {
            get { return new Version(1, 0, 0, 0);}
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string description
        {
            get { return "Plugin for substring searching in txt file"; }
        }

        /// <summary>
        /// Автор плагина
        /// </summary>
        public string authorName
        {
            get { return "Dmitrii Sitnik"; }
        }

        /// <summary>
        /// Форма для отображения плагина
        /// </summary>
        Form newForm = null;

        /// <summary>
        /// Инициализация плагина
        /// </summary>
        /// <param name="mainContainer"> Основная форма приложения</param>
        public void Initialize(object mainContainer)
        {
            Form form = (Form)mainContainer;

            MenuStrip mnu = null;
            if (form.Controls.Find("MenuStrip1", false) != null && form.Controls.Find("MenuStrip1", false).Length > 0)
            {
                mnu = (MenuStrip)form.Controls.Find("MenuStrip1", false)[0];
            }

            //создаем новые элементы меню
            ToolStripMenuItem myMenu = new ToolStripMenuItem();
            myMenu.Text = this.name;
            ToolStripMenuItem goToPlagin = new ToolStripMenuItem();
            ToolStripMenuItem aboutMenu = new ToolStripMenuItem();
            goToPlagin.Text = this.name;
            aboutMenu.Text = "About " + this.name;
            goToPlagin.Click += new EventHandler(GoToPlugin_Click);
            aboutMenu.Click += new EventHandler(AboutMenu_Click);
            myMenu.DropDownItems.Add(goToPlagin);
            myMenu.DropDownItems.Add(aboutMenu);
            mnu.Items.Add(myMenu);
        }

        public void Dispose()
        {

        }

        /// <summary>
        /// Переход к форме плагина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GoToPlugin_Click(object sender, EventArgs e)
        {
            newForm = new Form1();
            newForm.Show();
        }

        /// <summary>
        /// Информация о плагине
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.description, this.name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
