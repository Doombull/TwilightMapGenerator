using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class HomeSystem : ISystem
	{
		public int Player { get; set; }

		public double x { get; set; }
		public double y { get; set; }
		public int r { get; set; }
		public int q { get; set; }
		public string Panel { get; set; }

		public HomeSystem(int player)
		{
			Panel = "Homesystems";
			Player = player;
		}

		public string GetName()
		{
			return Player.ToRomanNumeral(new StringBuilder("Tile-HS_z_", 15));
		}

		public int CompareTo(ISystem other)
		{
			return this.GetValue().CompareTo(other.GetValue());
		}

		public double GetValue()
		{
			return 0;
		}
	}
}