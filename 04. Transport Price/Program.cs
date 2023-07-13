using System;

namespace _04._Transport_Price
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int kilometers = int.Parse(Console.ReadLine());
			string when = Console.ReadLine();
			double bestPrice = 0.00;

			if (when == "day")
			{
				if (kilometers < 20)
				{
					bestPrice = 0.7 + (kilometers * 0.79);
				}
				else if (kilometers < 100)
				{
					bestPrice = kilometers * 0.09;

				}
				else
				{
					bestPrice = kilometers * 0.06;
				}
			}

			else if (when == "night")
			{
				if (kilometers < 20)
				{
					bestPrice = 0.7 + (kilometers * 0.90);
				}
				else if (kilometers < 100)
				{
					bestPrice = kilometers * 0.09;

				}
				else
				{
					bestPrice = kilometers * 0.06;
				}
			}

			Console.WriteLine($"{bestPrice:f2}");
		}
	}	
}
