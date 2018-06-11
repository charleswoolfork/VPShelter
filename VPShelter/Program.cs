using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	class Program
	{
		
			static void Main(string[] args)
			{
			//This part allows the user to assignin random numbers to fields.
			Random random = new Random();
			int Hunger = random.Next(90, 100);
			int Thirst = random.Next(50, 70);
			

			//PROPERTIES
			VirtualPet userPet = new VirtualPet();
			userPet.Hunger = Hunger;
			userPet.Thirst = Thirst;
			

			//UI
			Console.WriteLine("Welcome to the Virtual Pet Shelter!\n Please enter your employee type \n 1- for Manager \n 2- for Volunteer.");
			Console.WriteLine(" Great! - Press any key to view pets status and choose further action...");
			Console.ReadLine();
			Console.Clear();

			do
			{
				userPet.GetStatus(); 
				//if (userImput ==1) 
				//USER MENU 1 (Manager Menu)
				Console.WriteLine("What would you like to do?");
				Console.WriteLine("\tPress 1 to feed {0}.", userPet.PetsName);
				Console.WriteLine("\tPress 2 to give {0} water.", userPet.PetsName);
				Console.WriteLine("\tPress 3 to play with {0}.", userPet.PetsName);
				Console.WriteLine("\tPress 4 to adopt {0}.", userPet.PetsName);
				Console.WriteLine("\tPress 5 to quit the game.");
				int userChoice = int.Parse(Console.ReadLine());

				while (userChoice < 1 || userChoice > 5)
				{
					Console.WriteLine("You must choose 1 - 4 from the menu!\nWhat do you want to do for your pets?");
					userChoice = int.Parse(Console.ReadLine());
				}

				switch (userChoice)
				{

					case 1:
						{
							userPet.FeedPet();
						}
						break;

					case 2:
						{
							userPet.WaterPet();
						}
						break;

					case 3:
						{
							userPet.PlayWithPet();
							break;
						}
					case 4:
						{
							Console.WriteLine("{0} says, \"Has been adopted!\"", userPet.PetsName);
							Console.WriteLine("the pets are very happy");
							Environment.Exit(0);
						}
						break;
					case 5:
						{
							Console.WriteLine("{0} says, \"What a great worker!\"", userPet.PetsName);
							Console.WriteLine("the pets are very happy");
							Environment.Exit(0);
						}
						break;
						// else (userImput == 2)
						// USER MENU 2 - Volunteer Menu goes here with additional switch case dialogue 
						

				}
				Console.WriteLine("Press any key to continue");
				Console.ReadLine();


			} while (userPet.PetHappiness <= 75);

			//this section is what prints to the console when the virtual puppy's satisfaction is greater than  or equal to 75).

			//Console.WriteLine("\nCongratulations {0}!\nYou have made {1} very happy today!\nThanks for playing Virtual Pet Shelter!", userPet.PetsName);

		}//MAIN

	}//CLASS

}//NAMESPACE


//The Program class MUST house your Main method, and be responsible for reading user input and writing output to the console.
//•	  The application MUST also include a game loop in this project.It should prompt the user, then call the appropriate method(s) on any of the required classes.


//Program class
//•	The Main method MUST have a program that…
//o asks for user input.
//o     writes output to the console.

//•	Available user interface actions MUST include(at minimum)…
//o Volunteer feeding all the pets
//o Volunteer watering all the pets
//o Volunteer or Manager viewing status of pets
//o Volunteer or Manager playing with an individual pet
//o     Manager to coordinate adoption of a pet, which should display a list of pet names and descriptions, allowing a user to select one
