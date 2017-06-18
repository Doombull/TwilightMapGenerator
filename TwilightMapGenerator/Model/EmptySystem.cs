using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class EmptySystem : ISystem
	{
		public double x { get; set; }
		public double y { get; set; }
		public int r { get; set; }
		public int q { get; set; }
		public string Panel { get; set; }

		public EmptySystem()
		{
			Panel = "Special";
		}

		public string GetName()
		{
			return "Tile-Empty" + Random.Next(1, 5);
		}

		public double GetValue()
		{
			return 0;
		}

		public int CompareTo(ISystem other)
		{
			return this.GetValue().CompareTo(other.GetValue());
		}
	}
}
