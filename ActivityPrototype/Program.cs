using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPrototype
{
	class Program
	{
		static void Main(string[] args)
		{
			// The code provided will print ‘Hello World’ to the console.
			// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
			var activity1 = ActivityFactory.API.ClientCheckMachineStatus.CreateActivity();
			var activity2 = ActivityFactory.API.ClientGetKey.CreateActivity();

			Console.WriteLine($"{activity1.ActivityName}:{activity1.TypeName}");
			Console.WriteLine($"{activity2.ActivityName}:{activity2.TypeName}");

			TestFunction().Wait();
			Console.ReadKey();
		}

		static async Task TestFunction()
		{
			using (var activity = ActivityFactory.API.ClientCheckMachineStatus.CreateActivity())
			{
				await Task.Delay(1000);
				activity.Result = ActivityResult.Success;
			}
		}
	}
}
