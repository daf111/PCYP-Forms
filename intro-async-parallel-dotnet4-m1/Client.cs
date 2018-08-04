using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_async_parallel_dotnet4_m1
{
    public class Client
    {
        public string name { get; set; }
        public double initialPrice { get; set; }
        public double excercisePrice { get; set; }
        public double upGrowth { get; set; }
        public double downGrowth { get; set; }
        public double interestRate { get; set; }
        public long periods { get; set; }
        public long simulations { get; set; }
    }
}
