using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	class NullValuator : IValuator
	{
		public double GetValue(PlanetSystem system)
		{
			return 0;
		}
	}
}
