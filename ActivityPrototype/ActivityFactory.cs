using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPrototype
{
	public static class ActivityFactory
	{
		public static class API
		{
			public static ActivityDefinition ClientCheckMachineStatus = new ActivityDefinition(nameof(API), nameof(ClientCheckMachineStatus));

			public static ActivityDefinition ClientGetKey = new ActivityDefinition(nameof(API), nameof(ClientGetKey));
		}

		public static class GraphApi
		{
			public static ActivityDefinition RetriveTenantDetails = new ActivityDefinition(nameof(GraphApi), nameof(RetriveTenantDetails));

			public static ActivityDefinition GetGraphUser = new ActivityDefinition(nameof(GraphApi), nameof(GetGraphUser));
		}
	}

	public class ActivityDefinition
	{
		public ActivityDefinition(string activityName, string typeName)
		{
			ActivityName = activityName;
			TypeName = typeName;
		}

		private string ActivityName { get; }

		private string TypeName { get; }

		public Activity CreateActivity(ActivityResult initialResult = ActivityResult.Failure)
		{
			return new Activity(ActivityName, TypeName, initialResult);
		}

		public Monitor CreateMonitory(ActivityTier tier = ActivityTier.Tier0)
		{
			return new Monitor($"{ActivityName}:{TypeName}", tier);
		}
	}
}
