using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class PlanetSystem : ISystem
	{
		public double x { get; set; }
		public double y { get; set; }
		public int r { get; set; }
		public int q { get; set; }
		public string Panel { get; set; }

		public IEnumerable<Planet>Planets { get; set; }

		public IValuator Valuator { get; set; }

		public PlanetSystem(IEnumerable<Planet> planets)
		{
			Panel = "Planets";
			Planets = new List<Planet>(planets);
			Valuator = new MaxOnlyResourceWeightedValuator();
		}

		public double GetValue()
		{
			return Valuator.GetValue(this);
		}

		public string GetName()
		{
			StringBuilder name = new StringBuilder("Tile-", 50);

			foreach (Planet planet in Planets)
			{
				if (planet.Name.StartsWith("Rigel"))
				{
					name.Append("Rigel");
					break;
				}

				if (planet.Name.StartsWith("Vega"))
				{
					name.Append("Vega");
					break;
				}

				if (name.Length > 5)
					name.Append("-");

				name.Append(planet.Name);
			}



			return name.ToString();
		}

		public int CompareTo(ISystem other)
		{
			return this.GetValue().CompareTo(other.GetValue());
		}
	}
}
