using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marker
{
    class Program
    {
        static void Main(string[] args)
        {
                Print p = new Print { Fill = 100, Color = 1 };
                p.Write();
        }
    }
}