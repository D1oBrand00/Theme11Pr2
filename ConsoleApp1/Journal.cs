using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Journal
    {
        /// <summary>
        /// Поле названия журнала
        /// </summary>
        public string nameJournal;
        /// <summary>
        /// Поле номера журнала
        /// </summary>
        public int number;
        /// <summary>
        /// Поле даты выпуска журнала
        /// </summary>
        public string date;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Journal() { }
        /// <summary>
        /// Конструктор с параметрами, инициализирующий объекты
        /// </summary>
        /// <param name="nameJournal"></param>
        /// <param name="number"></param>
        /// <param name="date"></param>
        public Journal(string nameJournal, int number, string date)
        {
            this.nameJournal = nameJournal;
            this.number = number;
            this.date = date;
        }
        /// <summary>
        /// Метод вывода всей информации об объекте
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"Название газеты - {nameJournal}\tНомер газеты - {number}\tДата выпуска - {date}";
        }
    }
}
