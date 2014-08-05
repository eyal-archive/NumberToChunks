namespace NumberToChunks
{
	using System.Collections.Generic;
	using System.Globalization;

	public static class NumberToChunks
	{
		public static IEnumerable<int> GetChunks(long number, int chunkSize)
		{
			string set = number.ToString(CultureInfo.InvariantCulture);

			int i = 0;

			while (i < set.Length)
			{
				i += chunkSize;

				int position = set.Length - i;

				bool isNegative = position < 0;

				int index = isNegative ? 0 : position;

				int length = isNegative ? chunkSize + position : chunkSize;

				int chunk = int.Parse(set.Substring(index, length));

				yield return chunk;
			}
		}
	}
}