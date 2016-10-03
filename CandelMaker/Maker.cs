using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandelMaker
{
    enum TypeCandel { Range, Volume, RangeMove, None };
    public class Maker
    {
        private TypeCandel candel = TypeCandel.None;
        private double setting;
        private String fileRead;
        private String fileSave;
        private FileHelper fileHelper;
        private StringParser parser;

        /// <summary>
        /// Проверка заполненности полей настройки и запуск на выполнение.
        /// </summary>
        public void MakeCandel(Button bt)
        {
            if (setting <= 0 || candel == TypeCandel.None || fileRead == "" || fileSave == "")
            {
                MessageBox.Show("Fill all the fields.");
                return;
            }
            
            switch (candel)
            {
                    case TypeCandel.Range:
                    case TypeCandel.Volume:
                    case TypeCandel.RangeMove:
                        bt.Enabled = false;
                        Start();
                        bt.Enabled = true;
                        break;
                    default :
                        MessageBox.Show("Select candel type!");
                        break;
            }
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
                case "RangeMove":
                    candel = TypeCandel.RangeMove;
                    break;
                default:
                    candel = TypeCandel.None;
                    break;
            }
        }

        /// <summary>
        /// Задать тип свечи
        /// </summary>
        private void getCandelType()
        {
            switch (candel)
            {
                    case TypeCandel.RangeMove:
                    new RangeMoveCandel(setting, fileHelper, parser).getCandel();
                        break;
                    case TypeCandel.Range:
                        new RangeCandel(setting, fileHelper, parser).getCandel();
                        break;
                    case TypeCandel.Volume:
                        new VolumeCandel(setting, fileHelper, parser).getCandel();
                        break;
            }
        }

        private void Start()
        {
            fileHelper = new FileHelper(fileRead, fileSave + "\\" + candel + "-" + setting + ".csv");
            // TODO реализовать настройку исходных данных в GUI
            parser = new StringParser();
            getCandelType();
        }
    }
}
