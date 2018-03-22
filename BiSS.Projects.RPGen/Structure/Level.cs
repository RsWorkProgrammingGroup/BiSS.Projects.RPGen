﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiSS.Projects.RPGen.Structure
{
	
	public enum Level
	{
		A=1,B=2,C=3,D=4
	}
	public static class LevelEx{
		public static string Name(this Level l)
		{
			switch (l)
			{
				case Level.A:
					return "A";
				case Level.B:
					return "B";
				case Level.C:
					return "C";
				case Level.D:
					return "D";
				default:
					return "EX_LEVEL";
			}
		}
		public static int Id(this Level l)
		{
			switch (l)
			{
				case Level.A:
					return 1;
				case Level.B:
					return 2;
				case Level.C:
					return 3;
				case Level.D:
					return 4;
				default:
					return Int32.MinValue;
			}
		}
	}
	public  class DLevel
	{
		private Dictionary<string,float[]> value=new Dictionary<string, float[]>();

		public float[] this[string id]
		{
			get { return value[id] ?? null; }
			set { this.value[id] = value; }
		}
	}
}
