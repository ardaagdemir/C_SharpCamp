using System;
using System.Collections.Generic;
using System.Text;

namespace _13_ObjectOrientedProgramming
{
    class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; } //Bu satır referans alanları olarak adlandırılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //Bu tip classlarda yalnızca özellik olur.


    }
}
