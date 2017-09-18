using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchUtil
{
    public interface IPlugin
    {
        /// <summary>
        /// Интерфейс для реализации Plug-in'ов
        /// </summary>
        ///Название
        string name { get; }
        /// <summary>
        /// версия плагина
        /// </summary>
        Version version { get; }

        /// <summary>
        /// Описание 
        /// </summary>
        string description { get; }
        
        /// <summary>
        /// Имя автора
        /// </summary>
        string authorName { get;  }

        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="mainContainer"> Объект основной формы</param>
        void Initialize(object mainContainer);

        /// <summary>
        /// Не используется
        /// </summary>
        void Dispose();
    }
}
