using Area51_ThreadVersion;
using System.Threading;

namespace Area51_ThreadVersion
{
	internal class Area51Simulator
	{
		static (string Identifier, string SecurityLevel) newAgent;

		static void Main(string[] args)
		{
			Console.WriteLine("Initiating Area 51 Simulation");
			Console.WriteLine("Press ENTER to activate the simulation.");
			Console.ReadLine();

			Random randomGen = new Random();
			int currentElevatorFloor = 1;
			Console.WriteLine("Elevator is currently at floor: " + currentElevatorFloor);

            for (int i = 0; i < randomGen.Next(1, 20); i++)
			{
				Console.WriteLine("A new agent has entered the elevator.");
				Console.WriteLine();

				Thread agentCreationThread = new Thread(AssignAgentDetails);
				agentCreationThread.Start();
				agentCreationThread.Join();

				Thread elevatorMovementThread = new Thread(() => OperateElevator(newAgent.SecurityLevel, currentElevatorFloor));
				elevatorMovementThread.Start();
				elevatorMovementThread.Join();

				Console.WriteLine("#########################################");
			}

			Console.WriteLine("Simulation Complete. Elevator has been deactivated.");
		}

		public static void AssignAgentDetails()
		{
			Entities entities = new Entities();
			var randomizer = new Random();
			newAgent.Identifier = entities.AgentNames[randomizer.Next(entities.AgentNames.Count)];
			newAgent.SecurityLevel = entities.SecurityLevels[randomizer.Next(entities.SecurityLevels.Count)];
			Console.WriteLine("Assigned Agent: " + newAgent.Identifier);
			Console.WriteLine("Clearance Level: " + newAgent.SecurityLevel);
		}

		public static bool CheckClearance(string clearance, int floor)
		{
			if (clearance == "Confidential" && floor == 1)
			{
				Console.WriteLine("\nClearance Approved. Opening doors.");
				return true;
			}

			if (clearance == "Secret" && (floor == 1 || floor == 2))
			{
				Console.WriteLine("\nClearance Approved. Opening doors.");
				return true;
			}

			if (clearance == "Top-secret")
			{
				Console.WriteLine("\nClearance Approved. Opening doors.");
				return true;
			}

			Console.WriteLine("\nClearance Denied. Please select another floor.");
			return false;
		}

		public static void OperateElevator(string clearanceLevel, int elevatorFloor)
		{
			int destinationFloor;
			do
			{
				Random floorSelector = new Random();
				Console.WriteLine("Selecting floor: G[1], S[2], T1[3], T2[4]");
				destinationFloor = floorSelector.Next(1, 5);
				Console.Write($"Elevator moving to floor {destinationFloor} ");
				for (int j = 0; j < Math.Abs(destinationFloor - elevatorFloor); j++)
				{
					Console.Write(".");
					Thread.Sleep(1000);
				}

				Console.WriteLine();
				elevatorFloor = destinationFloor;
				Console.WriteLine("Elevator reached floor: " + elevatorFloor);
			} while (!CheckClearance(clearanceLevel, destinationFloor));
		}
	}
}
