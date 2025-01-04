using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCS.IOCS
{
    [IOCService]
    class Student
    {
        public Teacher teacher { get; set; }
        public School school { get; set; }  

        public void Study() 
        {
            teacher.Classes();
            Console.WriteLine("student start study!");
        }
    }
}
