using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      string totalAsString = Console.ReadLine();
      double totalAsDouble = Convert.ToDouble(totalAsString);
      Console.WriteLine($"{totalAsDouble} is equal too...");
      
      int goldValue = 10;
      int silverValue = 5;
      
      double goldCoins = Math.Floor(totalAsDouble/goldValue);
      double leftOver = (totalAsDouble % goldValue);
      
      double silverCoins = Math.Floor(leftOver/silverValue);
      
      double bronzeCoins = (leftOver % silverValue);
      
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Gold coins: {bronzeCoins}");

      
    }
  }
}
