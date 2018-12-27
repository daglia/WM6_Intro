﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan a = new Insan(5); // instance - örnekleme
            //a.yas = 5; //Farklı bir yere referans verildiği için field'tır.
            Insan b = new Insan(10); // Insan() Constructor
            //b.yas = 10;
            a = b;
            try
            {
                a.Yas = 18;
                a.DogumTarihi = new DateTime(2000, 1, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(a.Yas);
        }
    }
}
