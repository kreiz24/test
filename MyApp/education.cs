using System;
using System.Collections.Generic;

namespace EducationNumOne
{
    class education
    {
        static void Main(string[] args)
        {
        Character c = new Character();
        c.Hit(10);
        
        Console.WriteLine(c.Health);
        }
    }
}