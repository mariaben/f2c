﻿using System;

namespace org.mariaben.shevah.converter
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Input temperature in Fartnheit and press " +
				              "<ENTER>, 'q' for exit: ");				
			string inputValue = Console.ReadLine();
			
			while(inputValue != "q") 
			{	
				try 
				{
					double temperatureInFartnheit = Double.Parse(inputValue);
					
					double temperatureInCelcius = f2c(temperatureInFartnheit);
				
					Console.WriteLine(temperatureInFartnheit + "F = " + 
					                  temperatureInCelcius + "C");
				} 
				catch(Exception ex)
				{
					Console.WriteLine("Can not convert " + inputValue + ": " + 
					                  ex.Message);
				}
				finally 
				{
					Console.Write("Input temperature in Fartnheit and press " +
				              "<ENTER>, 'q' for exit: ");				
					inputValue = Console.ReadLine();					
				}
			}
			
			Console.WriteLine("Thank you for using F2C converter!");
		}
		
		private static double f2c(double temperatureInFartnheit) 
		{
			return (temperatureInFartnheit - 32) * 5 / 9;
		}
	}
}