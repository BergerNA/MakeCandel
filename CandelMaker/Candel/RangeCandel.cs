using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    /// <summary>
    /// Класс реализующий японские свечи дискретные по величине цены.
    /// </summary>
    class RangeCandel : Candel, ICandel
    {
        private int prevTime, prevDate;
        private double prevClose;

        private int range;
        private FileHelper file;
        private StringParser parser;
        private Tick tick = new Tick(0, 0, 0, 0);
        private Queue<Candel> bars;

        private string str;

        public RangeCandel(double value, FileHelper file, StringParser parser)
        {
            range = (int)value;
            this.file = file;
            this.parser = parser;
            bars = new Queue<Candel>(10000); 
        }

        public void getCandel()
        {
            str = file.readFirst();
            if (str != null)
                parser.parse(tick, str);
            open = high = low = close = tick.price;
            double priceTick;

            while (true)
            {
                prevClose = tick.price;
                prevTime = tick.time;
                prevDate = tick.date;
                str = file.readLine();

                if (str == null)
                {
                    file.write(bars);
                    break;
                }

                parser.parse(tick, str);
                priceTick = tick.price;

                if (tick.time < 100000) // Время 10 часов утра, время открытия рынка, Исключить предторговый аукцион
                    continue;
                if (prevDate != tick.date)  // Новый день = новая свеча
                {
                    if (bars.IsEmpty())
                        file.write(bars);
                    bars.Push(new Candel(prevDate, prevTime, open, high, low, prevClose, volume));
                    open = high = low = priceTick;
                    volume = tick.volume;
                    continue;
                }

                volume += tick.volume;
                high = Math.Max(high, priceTick);
                low = Math.Min(low, priceTick);

                if (high - low >= range) // Размер свечи больше или равен заданного значения range = новая свеча
                {
                    if (bars.IsEmpty())
                        file.write(bars);
                    bars.Push(new Candel(tick.date, tick.time, open, high, low, tick.price, volume));
                    open = high = low = priceTick;
                    volume = 0;
                }
            }
        }
    }
}
