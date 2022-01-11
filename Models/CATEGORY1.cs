using System;
using System.Collections.Generic;

namespace Basket_MVC.Models
{
    public class CATEGORY1
    {
         public int Id { get; set; }

         public string Name { get; set; }

         public string DataId { get; set; }

         public ICollection<PRODUCTS1> PRODUCTS1s { get; set; }
        
    }
}
