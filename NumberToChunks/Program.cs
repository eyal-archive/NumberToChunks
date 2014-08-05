namespace NumberToChunks
{
	using System;

	internal class Program
	{
		private static void Main(string[] args)
		{
			const long number = 132423123453 * 2;

			foreach (var chunk in NumberToChunks.GetChunks(number, 1))
			{
				Console.WriteLine(chunk);
			}

			Console.ReadKey(false);
		}
	}
}