using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Books
    {
        /// <summary>
        /// Поле названия книги
        /// </summary>
        public string nameBook;
        /// <summary>
        /// Поле имени автора
        /// </summary>
        public string author;
        /// <summary>
        /// Поле года выпуска
        /// </summary>
        public int year;
        /// <summary>
        /// Поле значения объёма в листах
        /// </summary>
        public int volume;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Books()
        { }
        /// <summary>
        /// Конструктор с параметрами, инициализирующий объекты
        /// </summary>
        /// <param name="nameBook"></param>
        /// <param name="author"></param>
        /// <param name="year"></param>
        /// <param name="volume"></param>
        public Books(string nameBook,string author,int year, int volume)
        {
            this.nameBook = nameBook;
            this.author = author;
            this.year = year;
            this.volume = volume;
        }
        /// <summary>
        /// Метод вывода всей информации об объекте
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"Название книги - {nameBook}\tАвтор - {author}\tГод выпуска книги - {year}\tОбъём книги в листах - {volume}";
        }

    }
}
