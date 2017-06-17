using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class MaxOnlyResourceWeightedValuator : IValuator
	{
		public double GetValue(PlanetSystem system)
		{
			double value = 0;

			foreach (Planet planet in system.Planets)
			{
				value += Math.Max(planet.Resource, planet.Influence * 2.0 / 3.0);
				value += planet.TechBonuses.Count() * (planet.Resource >= planet.Influence ? 1.0 : 2.0 / 3.0);
			}

			if (system.Planets.Count() > 1)
				value += 1.0;

			return value;
		}
	}
}
