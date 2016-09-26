using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandelMaker
{
    static class Program
    {
        public static String fileNameRead;
        public static String fileNameSave;
        private const String fileCsv = ".csv";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CandelMaker());
            
        }
    }
}
