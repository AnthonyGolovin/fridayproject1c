    
using System;
using System.Collections.Generic;
using Pastry.Store;

namespace Pastry.Store {

  public class Bread
  {
    public static void Main()
    {   
        Console.WriteLine("Welcome to Pierres Pastries: ");
        Console.WriteLine("Daily Deal: Bread: (Buy 2 get 1 FREE!) and Pastries: (Buy 1 for $2 or 3 for $5)");
        Console.WriteLine("================================================================================");
        Console.WriteLine("Bread Price: $5 per loaf");
        Console.WriteLine("Pastry Price: $2 per Pastry");
        Console.WriteLine("Please input the amount of Bread you would like: (Number form ex. 1,2,3 ect.)");
        string inputBread = (Console.ReadLine());
        Console.WriteLine("Please input the amount of Pastries you would like: (Number form ex. 1,2,3 ect.)");
        string inputPastry = (Console.ReadLine());



        Cart finalCart = new Cart(inputBread, inputPastry);
        // Cart pastry = new Cart(inputPastry);

        Console.WriteLine(finalCart);
        // Console.WriteLine(pastry);

    }
  }
public class Pastry
{

}
}