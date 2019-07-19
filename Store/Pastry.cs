using System;

namespace Pastry.Store
{
  class Cart
  {
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
          return "Bread Total: $" + _breadCart + " Pastry Total: $" + _pastryCart;
      }
  }
}