using System;
using System.Collections.Generic;

namespace Pastry.Store
{
//Bread Store classes with item Attributes:

  class Bread
  {
      private string _breadItem; 
      private int _breadCost { get; set; } 
      
      public Bread(string breadItem, int breadCost)
      {
          _breadItem = breadItem;
          _breadCost = 5;
      }
    //   public void
    //   {

    //   }
    //    public void SetCost(int newCost)
    //    {
    //        breadCost = newCost;
    //    }
  
  }
 //Pastry Store classes with item Attributes:
 class Pastry
  {
      private string _pastryItem; 
      private int _pastryCost { get; set; } 
      
      public Pastry(string pastryItem, int pastryCost)
      {
          _pastryItem = pastryItem;
          _pastryCost = 2;
      }
    //    public Cart(string breadCost, string pastryCost, int inputBread, int inputPastry)
    // {
    //     _breadCost = 5;
    //     _pastryCost = 2;
    //     _inputBread = inputBread;
    //     _inputPastry = _inputPastry;
    //     return "Bread Total: $" + _breadItem * breadCost + " Pastry Total: $" + _pastryItem * pastryCost;
    // }
}
//  class Cart
//  {
//       private string _breadItem; 
//       private int _breadCost { get; set; } 
//       private string _pastryItem; 
//       private int _pastryCost { get; set; } 

//     public Cart(string breadCost, string pastryCost, int inputBread, int inputPastry)
//     {
//         _breadCost = 5;
//         _pastryCost = 2;
//         _inputBread = inputBread;
//         _inputPastry = _inputPastry;
//         return "Bread Total: $" + _breadItem * breadCost + " Pastry Total: $" + _pastryItem * pastryCost;
//     }
//  }
}

