using System;

namespace _18_AdvancedGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(132, "Ahmet");
            students.Add(152, "Mehmet");
            students.Add(456, "Salih");
            students.Add(476, "Hasan");
            students.Add(898, "Kemal");
            students.Add(343, "Serkan");

            students.List();
        }
    }
}
