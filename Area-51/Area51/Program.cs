using Area51;
using System.Threading;

namespace Area51
{
	internal class Area51Simulation
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Area 51 Simulation Initiated");
			Console.WriteLine("Hit ENTER to commence.");
			Console.ReadLine();

			var randomizer = new Random();
			int targetFloor = 0;
			int elevatorFloor = 1;
			int iterations = randomizer.Next(1, 15);

			for (int i = 0; i < iterations; i++)
			{
				var operative = CreateOperative();
				DisplayOperativeDetails(operative);

				do
				{
					targetFloor = ChooseRandomFloor(randomizer, elevatorFloor);
					elevatorFloor = MoveElevator(elevatorFloor, targetFloor);
				}
				while (!VerifyAccess(operative, targetFloor));

				Console.WriteLine("****************************************");
			}

			Console.WriteLine("Simulation concluded. Elevator out of service.");
		}

		private static Agent CreateOperative()
		{
			var newAgent = new Agent();
			var entityData = new Entities();
			var rnd = new Random();

			newAgent.Identifier = entityData.AgentNames[rnd.Next(entityData.AgentNames.Count)];
			newAgent.SecurityLevel = entityData.SecurityLevels[rnd.Next(entityData.SecurityLevels.Count)];

			return newAgent;
		}

		private static void DisplayOperativeDetails(Agent agent)
		{
			Console.WriteLine("\nAgent Arrival:");
			Console.WriteLine("Identifier: " + agent.Identifier);
			Console.WriteLine("Clearance: " + agent.SecurityLevel);
			Console.WriteLine();
		}

		private static int ChooseRandomFloor(Random rnd, int currentFloor)
		{
			Console.WriteLine("Selecting destination floor...");
			int floorSelection = rnd.Next(1, 5);
			Console.Write($"Destination: Floor {floorSelection} ");
			return floorSelection;
		}

		private static int MoveElevator(int current, int target)
		{
			for (int k = 0; k < Math.Abs(target - current); k++)
			{
				Console.Write(".");
				Thread.Sleep(1000);
			}

			Console.WriteLine("\nElevator has reached: Floor " + target);
			return target;
		}

		private static bool VerifyAccess(Agent agent, int floor)
		{
			bool accessGranted = agent.SecurityLevel switch
			{
				"Confidential" => floor == 1,
				"Secret" => floor <= 2,
				"Top-secret" => true,
				_ => false
			};

			Console.WriteLine(accessGranted ?
				"\nAccess Granted. Opening doors..." :
				"\nAccess Denied. Select another floor.");

			return accessGranted;
		}
	}
}

