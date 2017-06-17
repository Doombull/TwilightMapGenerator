using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public interface IValuator
	{
		double GetValue(PlanetSystem system);
	}
}
