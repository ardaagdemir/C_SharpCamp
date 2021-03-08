using System;

namespace OOP_3
{//veritabanına loglama göndereceğimiz bir sınıf
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
