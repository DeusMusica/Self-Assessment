using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		var cities = new List();
		cities.Add("New York");
		cities.Add("London");
		cities.Add("Mumbai");
		cities.Add("Chicago");
		cities.Add(null);

		Console.WriteLine("No of elelemts: " + cities.Count);
	}

}