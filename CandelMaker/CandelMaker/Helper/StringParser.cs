using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandelMaker
{
    internal enum Separator
    {
        comma,
        period,
        space,
        semicolon,
        tab
    };
    internal enum DecimalSeparator
    {
        comma,
        period
    };

    /// <summary>
    /// Класс реализующий распарсивание строки согласно настроек пользователя.
    /// </summary>
    class StringParser
    {
        private Char strSeparator;
        private Char strDecimalSeparator;
        private string[] strarray;
        private string[] strdouble;

        private int date, time, volume;
        private double price;

        /// <summary>
        /// Стандартный конструктор.
        /// Разделитель - запятая.
        /// Десятичный разделитель - точка.
        /// </summary>
        public StringParser()
        {
            setSeparator(Separator.comma);
            setDecimalSeparator(DecimalSeparator.period);
        }

        /// <summary>
        /// Распарсивает входную строку.
        /// </summary>
        /// <param name="str"> Строка для распарсивания </param>
        /// <returns>Возвращает новый объкт класса Тик</returns>
        public Tick parse(String str)
        {
            try
            {
                strarray = str.Split(strSeparator);
                strdouble = strarray[2].Split(strDecimalSeparator);

                date = Convert.ToInt32(strarray[0]);
                time = Convert.ToInt32(strarray[1]);
                price = Convert.ToDouble(strdouble[0]) + Convert.ToDouble("0," + strdouble[1]);
                volume = Convert.ToInt32(strarray[3]);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Проблема со входными данными: " + str);
            }
            return new Tick(date,time,price,volume);
        }

        /// <summary>
        /// Распарсивает входную строку.
        /// </summary>
        /// <param name="tick"> Тик в который необходимо записать данные с распарсенной строки </param>
        /// <param name="str"> Строка для распарсивания </param>
        /// <returns>Возвращает входящий Тик</returns>
        public Tick parse(Tick tick, String str)
        {
            try
            {
                strarray = str.Split(strSeparator);
               // strdouble = strarray[2].Split(strDecimalSeparator);

                date = Int32.Parse(strarray[0]);//Convert.ToInt32(strarray[0]));
                time = Int32.Parse(strarray[1]);//Convert.ToInt32(strarray[1]);
                price = Double.Parse(strarray[2].Replace(".", ","));//Convert.ToDouble(strarray[2].Replace(".", ",")));
                //price = Convert.ToDouble(strdouble[0]) + Convert.ToDouble("0," + strdouble[1]);
                volume = Int32.Parse(strarray[3]);//Convert.ToInt32(strarray[3]);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Проблема со входными данными: " + str);
            }
            return tick.setTick(date, time, price, volume);
        }

        /// <summary>
        /// Задать разделитель.
        /// </summary>
        /// <param name="separator"> Тип разделителя значений </param>
        public void setSeparator(Separator separator)
        {
            switch (separator)
            {
                    case Separator.comma:
                    strSeparator = ',';
                    break;
                    case Separator.period:
                    strSeparator = '.';
                    break;
                    case Separator.semicolon:
                    strSeparator = ';';
                    break;
                    case Separator.space:
                    strSeparator = ' ';
                    break;
                    case Separator.tab:
                    strSeparator = '\t';
                    break;
            }
        }

        /// <summary>
        /// Задать разделитель десятичных цифр.
        /// </summary>
        /// <param name="decimalSeparator"> Тип разделителя десятичных цифр </param>
        public void setDecimalSeparator(DecimalSeparator decimalSeparator)
        {
            switch (decimalSeparator)
            {
                case DecimalSeparator.comma:
                    strDecimalSeparator = ',';
                    break;
                case DecimalSeparator.period:
                    strDecimalSeparator = '.';
                    break;
            }
        }
    }
}
