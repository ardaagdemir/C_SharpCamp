using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{//veritabanına loglama göndereceğimiz bir sınıf
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }

}
