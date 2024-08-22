using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_CSharpProblems
{
    internal class Complex
    {
        public int real;
        public int imgl;
        public Complex()
        {

        }
        public static bool  operator==(Complex c1,Complex c2)
        {
            return c1.real==c2.real && c1.imgl ==c2.imgl;
        }
        public static bool operator !=(Complex c1, Complex c2) {
            return c1.real != c2.real && c1.imgl != c2.imgl;

        }
    }
}
