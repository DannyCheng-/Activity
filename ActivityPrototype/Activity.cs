using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPrototype
{
	public class Activity : IDisposable
	{
		public Activity(string activityName, string typeName, ActivityResult result)
		{
			ActivityName = activityName;
			TypeName = typeName;
			stopWatch = Stopwatch.StartNew();
		}

		public string ActivityName { get; set; }

		public string TypeName { get; set; }

		private Stopwatch stopWatch;

		public TimeSpan Duration { get; private set; }

		public ActivityResult Result { get; set; }

		public void Dispose()
		{
			stopWatch.Stop();
			Duration =stopWatch.Elapsed;

			Console.WriteLine($"Activity {ActivityName}:{TypeName} finished with result {Result.ToString()}. The duration is {Duration.TotalMilliseconds} milliseconds");
		}
	}

	public enum ActivityResult
	{
		Failure,
		ExpectedFailure,
		Success
	}
}
