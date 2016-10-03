using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    /// <summary>
    /// Класс реализут чтение/запись файла
    /// </summary>
    class FileHelper
    {
        private string pathFileRead, pathFileWrite;

        private StreamReader fileRead;
        private FileInfo file;
        private StringParser parser;
        
        /// <summary>
        /// Конструктор класса FileHelper.
        /// </summary>
        /// <param name="pathRead"> Путь файла для чтения. </param>
        /// <param name="pathWrite"> Путь файла для записи. </param>
        public FileHelper(String pathRead, String pathWrite)
        {
            pathFileRead = pathRead;
            pathFileWrite = pathWrite;
            file = new FileInfo(pathWrite);
            fileRead = File.OpenText(pathFileRead);
        }

        /// <summary>
        /// Чтение строки из файла.
        /// </summary>
        /// <returns> Прочитанная строка файла </returns>
        public String readLine()
        {
            return fileRead.ReadLine();
        }

        /// <summary>
        /// Закрыть поток чтения файла
        /// </summary>
        public void readClose()
        {
            fileRead.Close();
        }

        /// <summary>
        /// Прочитать первую строку и вернуть указатель в начало файла.
        /// </summary>
        /// <returns> Первая прочитанная строка файла. </returns>
        public String readFirst()
        {
            String rezult = fileRead.ReadLine();
            fileRead.Close();
            fileRead = File.OpenText(pathFileRead);
            return rezult;
        }

        /// <summary>
        /// Зпись строки в файл.
        /// </summary>
        /// <param name="str"> Строка для записи </param>
        public void writeLine(String str)
        {
            StreamWriter fileWrite = file.AppendText();
            fileWrite.WriteLine(str);
            fileWrite.Close();
        }

        /// <summary>
        /// Запись данных из очереди в файл.
        /// </summary>
        /// <param name="bars"> Очередь свечей. </param>
        public void write(Queue<Candel> bars)
        {
            StreamWriter fileWrite = file.AppendText();
            while (bars.Length() != 0)
                fileWrite.WriteLine(bars.Pop().ToString());
            fileWrite.Close();
        }

        /// <summary>
        /// Запись данных в файл из очереди строк.
        /// </summary>
        /// <param name="bars"> Очередь строковых данных. </param>
        public void write(Queue<String> bars)
        {
            StreamWriter fileWrite = file.AppendText();
            while (bars.Length() != 0)
                fileWrite.WriteLine(bars.Pop());
            fileWrite.Close();
        }
    }
}
