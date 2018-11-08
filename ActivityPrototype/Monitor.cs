using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPrototype
{
	public class Monitor
	{
		public Monitor(string monitorName, ActivityTier tier)
		{
			monitorName = MonitorName;
			Tier = tier;
		}

		public string MonitorName { get; set; }

		public virtual double QualityWarningThreshold
		{
			get
			{
				switch (Tier)
				{
					case ActivityTier.Tier0:
						return 99.5;
					case ActivityTier.Tier1:
						return 95.0;
					case ActivityTier.Tier2:
						return 90.0;
					case ActivityTier.Tier3:
						return 80.0;
					default:
						return 0.0;
				}
			}
		}

		public virtual double QualityErrorThreshold
		{
			get
			{
				switch (Tier)
				{
					case ActivityTier.Tier0:
						return 99.0;
					case ActivityTier.Tier1:
						return 90.0;
					case ActivityTier.Tier2:
						return 80.0;
					case ActivityTier.Tier3:
						return 60.0;
					default:
						return 0.0;
				}
			}
		}

		public virtual double DurationWarningThreshold { get; set; }

		public virtual double DurationErrorThreshold { get; set; }

		public ActivityTier Tier { get; }
	}

	public enum ActivityTier
	{
		Tier0,
		Tier1,
		Tier2,
		Tier3
	}
}
