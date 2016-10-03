using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    /// <summary>
    /// Класс реализует единицу данных Тик.
    /// </summary>
    class Tick
    {
        public int date, time, volume;
        public double price;

        public Tick(int date, int time, double price, int volume)
        {
            this.date = date;
            this.time = time;
            this.price = price;
            this.volume = volume;
        }

        /// <summary>
        /// Задать данные тика.
        /// </summary>
        /// <param name="date"> Дата сделки. </param>
        /// <param name="time"> Время сделки. </param>
        /// <param name="price"> Цена сделки. </param>
        /// <param name="volume"> Объем сделки. </param>
        /// <returns></returns>
        public Tick setTick(int date, int time, double price, int volume)
        {
            this.date = date;
            this.time = time;
            this.price = price;
            this.volume = volume;
            return this;
        }
    }
}
