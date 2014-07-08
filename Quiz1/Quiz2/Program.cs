using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {

        static void Main(string[] args)
        {
            var query = from a in db.any
                        where primarykey(<=5)
                        select *;

            
        }
    }
}
