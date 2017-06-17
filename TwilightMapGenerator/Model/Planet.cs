using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class Planet
	{
		public string Name{ get; set; }

		public int Resource { get; set; }

		public int Influence { get; set; }

		public IEnumerable<TechBonus>TechBonuses { get; set; }

		public Planet()
		{
			TechBonuses = new List<TechBonus>();
		}

		public Planet(string name, int resource, int influence) : this()
		{
			Name = name;
			Resource = resource;
			Influence = influence;
		}

		public Planet(string name, int resource, int influence, IEnumerable<TechBonus> tech) : this(name, resource, influence)
		{
			TechBonuses = tech;
		}
	}
}
