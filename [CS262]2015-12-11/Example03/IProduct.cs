using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal interface IProduct
    {
        int Price { get; set; }

        string Name { get; set; }

        string GenerateReport();
    }
}