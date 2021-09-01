using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept01
{
        public class Employee  //Parent class
        {
            public float salary = 40000; //Employee attribute
        }
        public class Programmer : Employee //child class
        {
            public float bonus = 10000;
        }
    }
