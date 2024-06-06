using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
namespace app
{
    class Semestr
    {

        public void watchData()
        {
            var Start = new DateTime(2022, 1, 09, 8, 0, 0);
            Console.WriteLine("Семестр начинается:" + Start.ToString());

            var End = new DateTime(2023, 06, 30, 16, 0, 0);
            Console.WriteLine("Семестр начинается:" + End.ToString());

        }
    }
}