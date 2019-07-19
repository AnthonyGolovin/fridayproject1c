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
  }
}