using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    /// <summary>
    /// Интерфейс, декларирующий метод получения свечей из тиковых данных.
    /// </summary>
    interface ICandel
    {
        void getCandel();
    }
}
