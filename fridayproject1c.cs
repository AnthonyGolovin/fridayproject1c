    
using System;
using System.Collections.Generic;
using Pastry.Store;

namespace Pastry.Store {

  public class Store
  {
    public static void Main()
    {   
        //UI
        Console.WriteLine("Welcome to Pierres Pastries: ");
        Console.WriteLine("Daily Deal: Bread: (Buy 2 get 1 FREE!) and Pastries: (Buy 1 for $2 or 3 for $5)");
        Console.WriteLine("================================================================================");
        Console.WriteLine("Bread Price: $5 per loaf");
        Console.WriteLine("Pastry Price: $2 per Pastry");
        Console.WriteLine("Please input the amount of Bread you would like: (Number form ex. 1,2,3 ect.)");
        int inputBread = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input the amount of Pastries you would like: (Number form ex. 1,2,3 ect.)");
        int inputPastry = Convert.ToInt32(Console.ReadLine());

        //Menu Items
        Bread newBread = new Bread (inputBread, 5);
        Pastry newPastry = new Pastry(inputPastry, 2);


        // Bread finalCart = new Bread(inputBread, inputPastry);
        
        Console.WriteLine(breadCost * inputBread);
        // Console.WriteLine(finalCart);
        // Console.WriteLine(finalCart.GetCart());
        // Console.WriteLine(DailyDeal());
       
    }
  }
}