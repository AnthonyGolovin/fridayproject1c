using System;
using System.Collections.Generic;

namespace Pastry.Store
{
//Bread Store classes with item Attributes:

  class Bread
  {
      public int breadItem { get; set; } 
      public int breadCost { get; set; } 
      
      public Bread(int breadItem, int breadCost)
      {
          breadItem = breadItem;
          breadCost = 5;
      }
       public void Cost()
       {
           int dailyDeal = breadItem / 3;
           int cost = (breadItem - dailyDeal) * 5;
       }
  
  }
 //Pastry Store classes with item Attributes:
 class Pastry
  {
      public string pastryItem; 
      public int pastryCost { get; set; } 
      
      public Pastry(string pastryItem, int pastryCost)
      {
          pastryItem = pastryItem;
          pastryCost = 2;
      }
}

}

