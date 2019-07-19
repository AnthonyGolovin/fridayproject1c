using System;

namespace Pastry.Store
{
  class Bread
  {
      private int _breadCost { get; set; } 
      private int _breadCart; 
      
      public Bread(int breadCart, int breadCost)
      {
          _breadCart = breadCart;
          _breadCost = 5;
      }
    //    public string GetCart()
    //   {
    //       return "Bread Total: $" + _breadCart * breadCost;
    //   }
  }
//   class Pastry
//   {
//       private int pastryCost = 2;
//       private int _pastryCart;

//       public Cart(int breadCart, int pastryCart)
//       {
//           _breadCart = breadCart;
//           _pastryCart = pastryCart;
//       }
//       public int GetPastryCart()
//       {
//           return _pastryCart;
//       }
//       public void SetPastryCart(int newPastryCart)
//       {
//           _pastryCart = newPastryCart;
//       }
//        public string GetCart()
//       {
//           return "Bread Total: $" + _breadCart * breadCost + " Pastry Total: $" + _pastryCart * pastryCost;
//       }
}
