using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoContext context = new PlutoContext();

            // Loading Author Data Only Wihtout His Courses 

            var Author = context.Authors.Find(1);

            // Loads The Courses For Particular Author only (in a separate SQL query)

            var Courses = Author.Courses;


        }
    }
}
