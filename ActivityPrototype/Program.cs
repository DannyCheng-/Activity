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
			TestFunction().Wait();

			Console.ReadKey();
		}

		static async Task TestFunction()
		{
			using (var activity = Activities.API.ClientCheckMachineStatus.CreateActivity())
			{
				Console.WriteLine("Working on something...");
				await Task.Delay(1000);
				activity.Result = ActivityResult.Success;
			}
		}
	}
}
