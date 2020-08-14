using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Employee<T> : Person
    {
        public T Number { get; set; }
      

    }
}


