﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;

namespace Bootstrapper
{
    /**
    * Aplication entry
    * Pure fabrication main function to get the aplication running.
    * Allows more decupling of project files. 
    */
    class Strapper
    {
        static void Main(string[] args)
        {
            //Some pure fabrication!
            ModelView mod = new ModelView(); // Model view creates the model that creates the DB manager that connects to the db that exists
            Console.WriteLine("Starting backend");
            Console.ReadKey();
            //Console.ReadLine;
            //TODO the various Views?
        }
    }
}
