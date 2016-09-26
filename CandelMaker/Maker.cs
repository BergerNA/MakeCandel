using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandelMaker
{
    enum TypeCandel { Range, Volume, Deal, None };
    public class Maker
    {
        private TypeCandel candel = TypeCandel.None;
        private double setting;
        private String fileRead;
        private String fileSave;

        Queue<Candel> Bars = new Queue<Candel>(100000);

        private double close;
        private double open;
        private double high;
        private double low;
        private int date;
        private int time;
        private int volume;

        private int prevDate = 0;
        private int prevTime = 0;
        private double prevclose = 0;
        private double prevHigh = 0;
        private double prevLow = 0;

        public void MakeCandel(Button bt)
        {
            if (setting <= 0 || candel == TypeCandel.None || fileRead == "" || fileSave == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            
            bt.Enabled = false;
            switch (candel)
            {
                    case TypeCandel.Range:
                        RangeCandel();
                        break;
                    case TypeCandel.Volume:
                        VolumeCandel();
                        break;
                    case TypeCandel.Deal:
                        MessageBox.Show("Необходимо реализовать.");
                        break;
            }
            bt.Enabled = true;
        }

        public void SetCandelValue(String value)
        {
            if(value != "")
                setting = Double.Parse(value);
        }

        public void SetFileRead(String value)
        {
            fileRead = value;
        }

        public void SetFileSave(String value)
        {
            fileSave = value;
        }

        public void SetCandelType(String value)
        {
            switch (value)
            {
                case "Range":
                    candel = TypeCandel.Range;
                    break;
                case "Volume":
                    candel = TypeCandel.Volume;
                    break;
                case "Deal":
                    candel = TypeCandel.Deal;
                    break;
                default:
                    candel = TypeCandel.None;
                    break;
            }
        }

        private string[] strarray;
        private string[] strdouble;
        private void StrParse(String str)
        {
            try
            {
                strarray = str.Split(',');
                strdouble = strarray[2].Split('.');
 
                date = Convert.ToInt32(strarray[0]);
                time = Convert.ToInt32(strarray[1]);
                close = Convert.ToDouble(strdouble[0]) + Convert.ToDouble("0," + strdouble[1]);
                volume = Convert.ToInt32(strarray[3]);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Проблема со входными данными.");
            }
            
        }

        private void Write(FileInfo f)
        {
            StreamWriter w = f.AppendText();
            while (Bars.Length() != 0)
                w.WriteLine(Bars.Pop().ToString());
            w.Close();
        }

        private void RangeCandel()
        {
            StreamReader fr = File.OpenText(fileRead);
            string file = fileSave + "\\" + candel + "-" + setting + ".csv";
            FileInfo f = new FileInfo(file);
            while (true)
            {
                prevTime = time;
                prevclose = close;
                string str = fr.ReadLine();

                if (str != null)
                {
                    StrParse(str);
                    if (time < 100000 || date < 20100000)
                        break;
                    if (prevDate != date)
                    {
                        if (Bars.IsEmpty())
                            Write(f);
                        Bars.Push(new Candel(date, prevTime, open, high, low, prevclose, volume));
                        prevDate = date;
                    }
                    if (time == 100000)
                    {
                        open = close;
                        high = close;
                        low = close;
                    }
                    high = Math.Max(high, close);
                    low = Math.Min(low, close);

                    if (high - low >= setting)
                    {
                        if (Bars.IsEmpty())
                            Write(f);
                        Bars.Push(new Candel(date, time, open, high, low, close, volume));
                        open = close;
                        high = close;
                        low = close;
                    }
                }
                else break;
            }
            fr.Close();
            if (Bars.Length() > 0)
                Write(f);
        }


        private void VolumeCandel()
        {
            StreamReader fr = File.OpenText(fileRead);
            string file = fileSave + "\\" + candel + "-" + setting + ".csv";
            FileInfo f = new FileInfo(file);
            while (true)
            {
                prevTime = time;
                prevclose = close;
                string str = fr.ReadLine();

                if (str != null)
                {
                    StrParse(str);
                    if (time < 100000 || date < 20100000)
                        break;
                    if (prevDate != date)
                    {
                        if (Bars.IsEmpty())
                            Write(f);
                        Bars.Push(new Candel(date, prevTime, open, high, low, prevclose, volume));
                        prevDate = date;
                    }
                    if (time == 100000)
                    {
                        open = close;
                        high = close;
                        low = close;
                        prevHigh = close;
                        prevLow = close;
                    }
                    high = Math.Max(high, close);
                    low = Math.Min(low, close);

                    if (high - prevHigh >= setting || prevLow - low >= setting)
                    {
                        if (Bars.IsEmpty())
                            Write(f);
                        Bars.Push(new Candel(date, prevTime, open, high, low, prevclose, volume));
                        prevHigh = high;
                        prevLow = low;
                        open = close;
                        high = close;
                        low = close;
                    }
                }
                else break;
            }
            fr.Close();
            if (Bars.Length() > 0)
                Write(f);
        }
    }
}
