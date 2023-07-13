using System;

namespace _03._Harvest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int land = int.Parse(Console.ReadLine());
			double grapesSquare = double.Parse(Console.ReadLine());
			int neededLitersWine = int.Parse(Console.ReadLine());
			int workers = int.Parse(Console.ReadLine());

			double grapesTotal = (land * grapesSquare) * 0.4;
			double wine = grapesTotal / 2.5;

			if (wine < neededLitersWine)
			{
				double difference = Math.Floor(neededLitersWine - wine);
				Console.WriteLine($"It will be a tough winter! More {difference} liters wine needed.");
			}
			else
			{
				wine = Math.Floor(wine);
				Console.WriteLine($"Good harvest this year! Total wine: {wine} liters.");

				double wineLeft = Math.Ceiling(wine - neededLitersWine);
				double wineForWorker = Math.Ceiling(wineLeft / workers);
				Console.WriteLine($"{wineLeft} liters left -> {wineForWorker} liters per person.");
			}
		}
	}
}
