using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Rectangle
    {
        public int length, breadth;
        public Rectangle(int l , int b)
        {
            length = 1;
            breadth = b;
        }
        public int Area()
        {
            return length * breadth;
        }
    }
}
