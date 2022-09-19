using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_oop
{
    abstract class Base
    {
        public abstract string Name { get; init; }
        public abstract void printName();

        ~Base()
        {

        }
    }
}
