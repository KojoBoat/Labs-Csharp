using System;
using System.Collections.Generic;
using System.Text;

namespace Turntabl
{
    abstract class Person 
    {

        private string name;

       protected Person(string name)
        {
            this.name = name;
        }
        public abstract double Rating
        {
            get;
        }
    }
}
