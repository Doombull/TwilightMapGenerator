﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightMapGenerator.Model
{
	public class BlockingSystem : ISystem
	{
		public string Name { get; set; }

		public double x { get; set; }
		public double y { get; set; }
		public int r { get; set; }
		public int q { get; set; }
		public string Panel { get; set; }

		public BlockingSystem()
		{
			Panel = "Special";
		}

		public string GetName()
		{
			return "Tile-" + Name;
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