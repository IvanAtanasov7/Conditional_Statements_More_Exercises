using System;

namespace _01._Pipes_In_Pool
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int volume = int.Parse(Console.ReadLine());
			int pipe1 = int.Parse(Console.ReadLine());
			int pipe2 = int.Parse(Console.ReadLine());
			double hours = double.Parse(Console.ReadLine());

			double pipe1Filled = pipe1 * hours;
			double pipe2Filled = pipe2 * hours;
			double totalFilled = pipe1Filled + pipe2Filled;
			
			if (totalFilled <= volume)
			{
				double percentagePipe1 = pipe1Filled / totalFilled * 100;
				double percentagePipe2 = pipe2Filled / totalFilled * 100;
				double percentageTotalFilled = totalFilled / volume * 100;
				Console.WriteLine($"The pool is {percentageTotalFilled:F2}% full. Pipe 1: {percentagePipe1:F2}%. Pipe 2: {percentagePipe2:F2}%.");
            }
			else
			{
				double litersOver = totalFilled - volume;

				Console.WriteLine($"For {hours} hours the pool overflows with {litersOver} liters.");
            }

		}
	}
}
