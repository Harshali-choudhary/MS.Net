using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memMgmtApp
{
    internal class Product: IDisposable
    {

            public string Title { get; set; }
            public double unitPrice { get; set; }
            public Product(String title, double unitPrice)
            {
                Title = title;
                this.unitPrice = unitPrice;
            }

            ~Product() { }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
}
