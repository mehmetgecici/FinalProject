using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CatogoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStocks { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
