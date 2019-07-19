using System;

namespace Pastry.Store
{
  class Cart
  {
      private int breadCost = 5;
      private int pastryCost = 2;
      private int _breadCart; 
      private int _pastryCart;

      public Cart(int breadCart, int pastryCart)
      {
          _breadCart = breadCart;
          _pastryCart = pastryCart;
      }
      public int GetBreadCart()
      {
          return _breadCart;
      }
      public int GetPastryCart()
      {
          return _pastryCart;
      }
      public void SetBreadCart(int newBreadCart)
      {
          _breadCart = newBreadCart;
      }
      public void SetPastryCart(int newPastryCart)
      {
          _pastryCart = newPastryCart;
      }
       public string GetCart()
      {
          return "Bread Total: $" + _breadCart * breadCost + " Pastry Total: $" + _pastryCart * pastryCost;
      }
  }
}