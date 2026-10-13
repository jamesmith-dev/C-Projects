using System;

class Program
{
		static void Main()
		{
				// Array of US states
				string[] usStates = {
						"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
						"Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho",
						"Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana",
						"Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
						"Mississippi", "Missouri", "Montana", "Nebraska", "Nevada",
						"New Hampshire", "New Jersey", "New Mexico", "New York",
						"North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon",
						"Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
						"Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
						"West Virginia", "Wisconsin", "Wyoming"
				};

				// Output states to console
				Console.WriteLine("List of U.S. States:");
				foreach (var state in usStates)
				{
						Console.WriteLine(state);
				}

				Console.ReadKey();
		}
}
