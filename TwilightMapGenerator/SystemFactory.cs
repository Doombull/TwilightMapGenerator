using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TwilightMapGenerator.Model;

namespace TwilightMapGenerator
{
	public static class SystemFactory
	{
		public static List<ISystem> GetPlanetSystems()
		{
			List<ISystem> systems = new List<ISystem>(new ISystem[]
			{
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Abyz", Resource = 3, Influence = 0 },
					new Planet() { Name = "Fria", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Arinam", Resource = 1, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Blue } },
					new Planet() { Name = "Meer", Resource = 0, Influence = 4 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Arnor", Resource = 2, Influence = 1 },
					new Planet() { Name = "Lor", Resource = 1, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Ashtroth", Resource = 2, Influence = 0 },
					new Planet() { Name = "Loki", Resource = 1, Influence = 2 },
					new Planet() { Name = "Abaddon", Resource = 1, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Bereg", Resource = 3, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Red } },
					new Planet() { Name = "Lirta_IV", Resource = 2, Influence = 3, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Capha", Resource = 3, Influence = 0 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Centauri", Resource = 1, Influence = 3 },
					new Planet() { Name = "Gral", Resource = 1, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Coorneeq", Resource = 1, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Red } },
					new Planet() { Name = "Resculon", Resource = 2, Influence = 0 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Cormund", Resource = 2, Influence = 0 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Dal_Bootha", Resource = 0, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Red } },
					new Planet() { Name = "Xxehan", Resource = 1, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Elnath", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Everra", Resource = 3, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Faunus", Resource = 1, Influence = 3, TechBonuses = new TechBonus[] { TechBonus.Green, TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Garbozia", Resource = 2, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Hercalor", Resource = 1, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Yellow } },
					new Planet() { Name = "Tiamat", Resource = 1, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Yellow } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Hopes_End", Resource = 3, Influence = 0 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Industrex", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Red, TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Lazar", Resource = 1, Influence = 0 },
					new Planet() { Name = "Sakulag", Resource = 2, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Lesab", Resource = 2, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Lisis", Resource = 2, Influence = 2 },
					new Planet() { Name = "Velnor", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Lodor", Resource = 3, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Mehar_Xull", Resource = 1, Influence = 3, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Mellon", Resource = 0, Influence = 2 },
					new Planet() { Name = "Zohbat", Resource = 3, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Mirage", Resource = 1, Influence = 2 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "New_Albion", Resource = 1, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } },
					new Planet() { Name = "Starpoint", Resource = 3, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Perimeter", Resource = 2, Influence = 2 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Primor", Resource = 2, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Quann", Resource = 2, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Qucenn", Resource = 1, Influence = 2 },
					new Planet() { Name = "Rarron", Resource = 0, Influence = 3, TechBonuses = new TechBonus[] { TechBonus.Green } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Rigel_I", Resource = 0, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Green } },
					new Planet() { Name = "Rigel_II", Resource = 1, Influence = 2 },
					new Planet() { Name = "Rigel_III", Resource = 1, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Saudor", Resource = 2, Influence = 2 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Sem-Lore", Resource = 3, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Yellow } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Sumerian", Resource = 2, Influence = 2 },
					new Planet() { Name = "Arcturus", Resource = 1, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Tarmann", Resource = 1, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Tempesta", Resource = 1, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Blue, TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Tequran", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Red } },
					new Planet() { Name = "Torkan", Resource = 0, Influence = 3, TechBonuses = new TechBonus[] { TechBonus.Blue } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Thibah", Resource = 1, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Tsion", Resource = 2, Influence = 2 },
					new Planet() { Name = "Bellatrix", Resource = 0, Influence = 1, TechBonuses = new TechBonus[] { TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Vefut_II", Resource = 2, Influence = 0, TechBonuses = new TechBonus[] { TechBonus.Red } }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Vega_Minor", Resource = 1, Influence = 2, TechBonuses = new TechBonus[] { TechBonus.Blue } },
					new Planet() { Name = "Vega_Major", Resource = 2, Influence = 1 }
				}),
				new PlanetSystem(new Planet[]
				{
					new Planet() { Name = "Wellon", Resource = 1, Influence = 2 }
				})
			});

			for (int i = 0; i < 14; i++)
				systems.Add(new EmptySystem());

			return systems;
		}

		public static List<ISystem> GetBlockingSystems()
		{
			List<ISystem> systems = new List<ISystem>(new ISystem[]
			{
				new BlockingSystem() { Name = "Asteroid_Field" },
				new BlockingSystem() { Name = "Asteroid_Field" },
				new BlockingSystem() { Name = "Asteroid_Field" },
				new BlockingSystem() { Name = "Asteroid_Field" },
				new BlockingSystem() { Name = "Gravity_rift" },
				new BlockingSystem() { Name = "Ion_Storm" },
				new BlockingSystem() { Name = "Ion_Storm" },
				new BlockingSystem() { Name = "Nebula" },
				new BlockingSystem() { Name = "Nebula" },
				new BlockingSystem() { Name = "Supernova" },
				new BlockingSystem() { Name = "Supernova" }
			});

			return systems;
		}
	}
}
