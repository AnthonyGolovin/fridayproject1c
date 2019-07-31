using System;
using System.Collections.Generic;

namespace The.Store
{
//Bread Store classes with item Attributes:

  class Bread
  {
      public int BreadItem { get; set; } //Quantity
      public int BreadCost { get; set; } //Cost
      public int TotalBread { get; set; } //Total

      public Bread(int breadItem, int breadCost)//Bread Constructor
      {
          BreadItem = breadItem;
          BreadCost = 5;
          TotalBread = breadAddUp();
      }
      public int breadAddUp() //Price calculator 
        {
           int remainder = BreadItem / 3;
           int TotalBread = (BreadItem - remainder) * BreadCost;
           return TotalBread;
        } 
  
  }
//  Pastry Store classes with item Attributes:
 class Pastry
  {
      public int PastryItem { get; set; } //Quantity
      public int PastryCost { get; set; } //Cost
      public int TotalPastry{ get; set; } //Total
      public int PastryPromo{ get; set; } //Pastry Promotion
      
      public Pastry(int pastryItem, int pastryCost)//Pastry Constructor
      {
          PastryItem = pastryItem;
          PastryCost = 2;
          PastryPromo = 5;
          TotalPastry= pastryAddUp();
      }
      
    public int pastryAddUp() //Price calculator 
        {
           int modulo = PastryItem % 3;
           int dailyDeal = PastryItem / 3;
           int TotalPastry = (PastryCost * modulo) + (dailyDeal * PastryPromo);
           return TotalPastry;
        } 
}

}

