using System;
using System.Collections.Generic;

namespace The.Store
{
//Bread Store classes with item Attributes:

  class Bread
  {
      public int BreadItem { get; set; } //Quantity
      public int breadCost { get; set; } //Cost
      public int totalBread { get; set; } //Total

      public Bread(int breadItem, int breadCost)//Bread Constructor
      {
          BreadItem = breadItem;
          breadCost = 5;
          totalBread = breadAddUp();
      }
      public int breadAddUp() //Price calculator 
        {
           int remainder = BreadItem / 3;
           int totalBread = (BreadItem - remainder) * breadCost;
           return totalBread;
        } 
  
  }
//  Pastry Store classes with item Attributes:
 class Pastry
  {
      public int PastryItem { get; set; } //Quantity
      public int pastryCost { get; set; } //Cost
      public int totalPastry{ get; set; } //Total
      public int pastryPromo{ get; set; } //Pastry Promotion
      
      public Pastry(int pastryItem, int pastryCost)//Pastry Constructor
      {
          PastryItem = pastryItem;
          pastryCost = 2;
          pastryPromo = 5;
          totalPastry= pastryAddUp();
      }
      
    public int pastryAddUp() //Price calculator 
        {
           int modulo = PastryItem % 3;
           int dailyDeal = PastryItem / 3;
           int totalPastry = (pastryCost * modulo) + (dailyDeal * pastryPromo);
           return totalPastry;
        } 
}

}

