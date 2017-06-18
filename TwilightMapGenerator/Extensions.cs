using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator
{
	static class Extensions
	{
		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = Random.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static string ToRomanNumeral(this int num, StringBuilder roman)
		{
			while (num > 0)
			{
				if (num >= 5)
				{
					roman.Append("V");
					num -= 5;
				}
				else if (num == 4)
				{
					roman.Append("IV");
					num -= 4;
				}
				else
				{
					roman.Append("I");
					num -= 1;
				}
			}

			return roman.ToString();
		}
	}
}
