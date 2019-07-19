using System;

namespace Pastry.Store
{
  class Cart
  {
      private string _breadCart; 
      private string _pastryCart;

      public Cart(string breadCart, string pastryCart)
      {
          _breadCart = breadCart;
          _pastryCart = pastryCart;
      }
    //   public string GetBreadCart()
    //   {
    //       return _bread;
    //   }
    //   public string GetPastryCart()
    //   {
    //       return _pastry;
    //   }
    //   public string GetCart()
    //   {
    //       return " $" + _breadCart + " $" + _pastryCart;
    //   }
      
  }
}