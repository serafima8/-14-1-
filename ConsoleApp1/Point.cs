using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        /// <summary>
        /// создание поля x
        /// </summary>
        private double x;
        /// <summary>
        /// создание поля y
        /// </summary>
        private double y;

        /// <summary>
        /// поле для подсчета количества созданных экземпляров класса
        /// </summary>
        public static double count;

        /// <summary>
        /// поле метода доступа к внутренним переменным x, y
        /// </summary>
        public double X
        { get { return x; } set { x = value; } }
        public double Y
        { get { return y; } set { y = value; } }




        /// <summary>
        /// конструктор с двумя параметрами, которые инициализируют одноименные внутренние поля класса
        /// </summary>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
            count++;
        }
        /// <summary>
        /// Конструктор по умолчанию, который инициализирует внутренние поля 
        /// </summary>
        public Point()
        {
            x = y = 1.0;
            count++;

        }
        /// <summary>
        /// Статический конструктор, который инициализирует статическую переменную count нулевым значением
        /// </summary>
        static Point()
        {
            count = 0;
        }
        /// <summary>
        /// Метод, который выводит информацию
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"x = {x}\ty = {y}\tcount = {count}");
        }
    }
}
