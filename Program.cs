﻿using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Wildan Ghulam Muhammad Ustmani", 20);
            person1.InfoPerson();

            Console.WriteLine("---------------------------------");

            Karyawan karyawan1 = new Karyawan("050704", "Dosen", "Gojo", 24);
            karyawan1.InfoKaryawan("050704", "Dosen");
            karyawan1.InfoPerson();

            Console.ReadKey();
        }
    }
}