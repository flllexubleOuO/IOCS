﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCS.IOCS
{
    [IOCService]
    class Teacher
    {
        public void Classes() 
        {
            Console.WriteLine("The teacher is giving a lecture!");
        }
    }
}
