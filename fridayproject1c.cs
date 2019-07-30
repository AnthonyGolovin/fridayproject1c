    
using System;
using System.Collections.Generic;
using The.Store;

namespace Menu
{
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

        //Bread Purchase
        Bread bread = new Bread(inputBread, 5);
        int remainder = inputBread / 3;
        int breadTotal = (inputBread - remainder) * 5;
        Console.WriteLine("The bread will cost $" + breadTotal);
        
        // Pastry 
        Pastry pastry = new Pastry(inputPastry, 2);
        int modulo = inputPastry % 3;
        int dailyDeal = inputPastry / 3;
        int pastryTotal = (2 * modulo) + (dailyDeal * 5);
        Console.WriteLine("The pastry will cost $ " + pastryTotal);
       
    }
  }
}