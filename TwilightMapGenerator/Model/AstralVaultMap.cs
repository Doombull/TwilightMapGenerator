using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class AstralVaultMap
	{
		public List<Sector> Sectors { get; set; }

		public AstralVaultMap(List<Sector> sectors)
		{
			Sectors = sectors;
		}

		public string Generate()
		{
			PositionOnMap();

			StringBuilder generatedSystems = new StringBuilder();
			string systemTemplate = "{{\"id\":\"{0}\",\"x\":{1},\"y\":{2},\"q\":{3},\"r\":{4},\"panel\":\"{5}\",\"rotation\":0}}";
			string map = "{{\"map\":[{{\"id\":\"Tile-Mecatol_Rex\",\"x\":0,\"y\":0,\"q\":0,\"r\":0,\"panel\":\"Planets\",\"rotation\":0}},{0}]}}";
			
			foreach (Sector sector in Sectors)
			{
				foreach (ISystem system in sector.Systems)
				{
					if (generatedSystems.Length > 0)
						generatedSystems.Append(",");

					generatedSystems.Append(String.Format(systemTemplate, system.GetName(), system.x, system.y, system.q, system.r, system.Panel));
				}
			}

			return String.Format(map, generatedSystems.ToString());
		}

		private void PositionOnMap()
		{
			Sectors[0].Systems[0].x = 0;
			Sectors[0].Systems[0].y = -565.5145886712385;
			Sectors[0].Systems[0].q = 0;
			Sectors[0].Systems[0].r = 1;

			Sectors[0].Systems[1].x = 0;
			Sectors[0].Systems[1].y = -1131.0291773424767;
			Sectors[0].Systems[1].q = 0;
			Sectors[0].Systems[1].r = 2;

			Sectors[0].Systems[2].x = 489.75000000000045;
			Sectors[0].Systems[2].y = -848.2718830068577;
			Sectors[0].Systems[2].q = 1;
			Sectors[0].Systems[2].r = 1;

			Sectors[0].Systems[3].x = 0;
			Sectors[0].Systems[3].y = -1696.5437660137151;
			Sectors[0].Systems[3].q = 0;
			Sectors[0].Systems[3].r = 3;

			Sectors[0].Systems[4].x = 489.75000000000045;
			Sectors[0].Systems[4].y = -1413.7864716780961;
			Sectors[0].Systems[4].q = 1;
			Sectors[0].Systems[4].r = 2;

			Sectors[0].Systems[5].x = 979.5;
			Sectors[0].Systems[5].y = -1131.0291773424767;
			Sectors[0].Systems[5].q = 2;
			Sectors[0].Systems[5].r = 1;


			Sectors[1].Systems[0].x = 489.75;
			Sectors[1].Systems[0].y = -282.75729433561923;
			Sectors[1].Systems[0].q = 1;
			Sectors[1].Systems[0].r = 0;

			Sectors[1].Systems[1].x = 979.5;
			Sectors[1].Systems[1].y = -565.5145886712382;
			Sectors[1].Systems[1].q = 2;
			Sectors[1].Systems[1].r = 0;

			Sectors[1].Systems[2].x = 979.5;
			Sectors[1].Systems[2].y = 0;
			Sectors[1].Systems[2].q = 2;
			Sectors[1].Systems[2].r = -1;

			Sectors[1].Systems[3].x = 1469.25;
			Sectors[1].Systems[3].y = -848.2718830068572;
			Sectors[1].Systems[3].q = 3;
			Sectors[1].Systems[3].r = 0;

			Sectors[1].Systems[4].x = 1469.25;
			Sectors[1].Systems[4].y = -282.757294335619;
			Sectors[1].Systems[4].q = 3;
			Sectors[1].Systems[4].r = -1;

			Sectors[1].Systems[5].x = 1469.25;
			Sectors[1].Systems[5].y = 282.75729433561946;
			Sectors[1].Systems[5].q = 3;
			Sectors[1].Systems[5].r = -2;


			Sectors[2].Systems[0].x = 489.75;
			Sectors[2].Systems[0].y = 282.75729433561923;
			Sectors[2].Systems[0].q = 1;
			Sectors[2].Systems[0].r = -1;

			Sectors[2].Systems[1].x = 979.4999999999995;
			Sectors[2].Systems[1].y = 565.5145886712387;
			Sectors[2].Systems[1].q = 2;
			Sectors[2].Systems[1].r = -2;

			Sectors[2].Systems[2].x = 489.75;
			Sectors[2].Systems[2].y = 848.2718830068577;
			Sectors[2].Systems[2].q = 1;
			Sectors[2].Systems[2].r = -2;

			Sectors[2].Systems[3].x = 1469.2499999999997;
			Sectors[2].Systems[3].y = 848.2718830068574;
			Sectors[2].Systems[3].q = 3;
			Sectors[2].Systems[3].r = -3;

			Sectors[2].Systems[4].x = 979.4999999999998;
			Sectors[2].Systems[4].y = 1131.0291773424765;
			Sectors[2].Systems[4].q = 2;
			Sectors[2].Systems[4].r = -3;

			Sectors[2].Systems[5].x = 489.75;
			Sectors[2].Systems[5].y = 1413.7864716780955;
			Sectors[2].Systems[5].q = 1;
			Sectors[2].Systems[5].r = -3;


			Sectors[3].Systems[0].x = 0;
			Sectors[3].Systems[0].y = 565.5145886712385;
			Sectors[3].Systems[0].q = 0;
			Sectors[3].Systems[0].r = -1;

			Sectors[3].Systems[1].x = 0;
			Sectors[3].Systems[1].y = 1131.0291773424765;
			Sectors[3].Systems[1].q = 0;
			Sectors[3].Systems[1].r = -2;

			Sectors[3].Systems[2].x = -489.75;
			Sectors[3].Systems[2].y = 848.2718830068575;
			Sectors[3].Systems[2].q = -1;
			Sectors[3].Systems[2].r = -1;

			Sectors[3].Systems[3].x = 0;
			Sectors[3].Systems[3].y = 1696.543766013715;
			Sectors[3].Systems[3].q = 0;
			Sectors[3].Systems[3].r = -3;

			Sectors[3].Systems[4].x = -489.75;
			Sectors[3].Systems[4].y = 1413.786471678096;
			Sectors[3].Systems[4].q = -1;
			Sectors[3].Systems[4].r = -2;

			Sectors[3].Systems[5].x = -979.5;
			Sectors[3].Systems[5].y = 1131.0291773424765;
			Sectors[3].Systems[5].q = -2;
			Sectors[3].Systems[5].r = -1;


			Sectors[4].Systems[0].x = -489.75;
			Sectors[4].Systems[0].y = 282.757294335619;
			Sectors[4].Systems[0].q = -1;
			Sectors[4].Systems[0].r = 0;

			Sectors[4].Systems[1].x = -979.5;
			Sectors[4].Systems[1].y = 565.5145886712385;
			Sectors[4].Systems[1].q = -2;
			Sectors[4].Systems[1].r = 0;

			Sectors[4].Systems[2].x = -979.5;
			Sectors[4].Systems[2].y = 0;
			Sectors[4].Systems[2].q = -2;
			Sectors[4].Systems[2].r = 1;

			Sectors[4].Systems[3].x = -1469.25;
			Sectors[4].Systems[3].y = 848.2718830068575;
			Sectors[4].Systems[3].q = -3;
			Sectors[4].Systems[3].r = 0;

			Sectors[4].Systems[4].x = -1469.25;
			Sectors[4].Systems[4].y = 282.757294335619;
			Sectors[4].Systems[4].q = -3;
			Sectors[4].Systems[4].r = 1;

			Sectors[4].Systems[5].x = -1469.25;
			Sectors[4].Systems[5].y = -282.75729433561923;
			Sectors[4].Systems[5].q = -3;
			Sectors[4].Systems[5].r = 2;


			Sectors[5].Systems[0].x = -489.75;
			Sectors[5].Systems[0].y = -282.75729433561946;
			Sectors[5].Systems[0].q = -1;
			Sectors[5].Systems[0].r = 1;

			Sectors[5].Systems[1].x = -979.4999999999998;
			Sectors[5].Systems[1].y = -565.5145886712385;
			Sectors[5].Systems[1].q = -2;
			Sectors[5].Systems[1].r = 2;

			Sectors[5].Systems[2].x = -489.75;
			Sectors[5].Systems[2].y = -848.2718830068577;
			Sectors[5].Systems[2].q = -1;
			Sectors[5].Systems[2].r = 2;

			Sectors[5].Systems[3].x = -1469.25;
			Sectors[5].Systems[3].y = -848.2718830068577;
			Sectors[5].Systems[3].q = -3;
			Sectors[5].Systems[3].r = 3;

			Sectors[5].Systems[4].x = -979.4999999999998;
			Sectors[5].Systems[4].y = -1131.0291773424767;
			Sectors[5].Systems[4].q = -2;
			Sectors[5].Systems[4].r = 3;

			Sectors[5].Systems[5].x = -489.75;
			Sectors[5].Systems[5].y = -1413.7864716780961;
			Sectors[5].Systems[5].q = -1;
			Sectors[5].Systems[5].r = 3;
		}
	}
}
