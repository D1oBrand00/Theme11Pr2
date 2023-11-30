using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bug
    {
        /// <summary>
        /// Поле названия насекомого
        /// </summary>
        public string nameBug;
        /// <summary>
        /// Поле значения скорости перемещения насекомого
        /// </summary>
        public int speed;
        /// <summary>
        /// Поле названия пищи насекомого
        /// </summary>
        public string food;
        /// <summary>
        /// Поле названия среды обитания насекомого
        /// </summary>
        public string habitat;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Bug()
        { }
        /// <summary>
        /// Конструктор с параметрами, инициализирующий объекты
        /// </summary>
        /// <param name="nameBug"></param>
        /// <param name="speed"></param>
        /// <param name="food"></param>
        /// <param name="habitat"></param>
        public Bug(string nameBug, int speed, string food, string habitat)
        {
            this.nameBug = nameBug;
            this.speed = speed;
            this.food = food;
            this.habitat = habitat;
        }
        /// <summary>
        /// Метод вывода всей информации об объекте
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $"Название насекомого - {nameBug}\tСкорость перемещения - {speed}\tПища - {food}\tСреда обитания - {habitat}";
        }
    }
}
