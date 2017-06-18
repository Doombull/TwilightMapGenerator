using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator
{
	public static class Random
	{
		private static System.Random random = new System.Random();

		public static int Next()
		{
			return random.Next();
		}

		public static int Next(int max)
		{
			return random.Next(max);
		}

		public static int Next(int min, int max)
		{
			return random.Next(min, max);
		}
	}
}
