using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
	class VirtualPet
	{
		// DECLARING FIELDS

		string petDescription;
		string petsName;
		int hunger;
		int thirst;
		int bathroomNeed;
		int energy;
		int affection;
		internal int PetHappiness;
		 
		//string petOne;
		//string petTwo;
		//string petThree;




		//DECLARING CONSTRUCTORS

		public VirtualPet()//DEFAULT CONSTRUCTOR
		{

		}
		public VirtualPet(string petDescription, string petsName)//LOADED CONSTRUCTOR 1
		{
			this.petsName = petsName;
		}
		public VirtualPet(int hunger, int thirst)//LOADED CONSTRUCTOR 2
		{
			this.hunger = hunger;
			this.thirst = thirst;
			////this.bathroomNeed = bathroom;
			//this.energy = energy;
			//this.affection = affection;
		}
		
		// DECLARING PROPERTIES

		public string PetsName
		{
			get { return this.petsName; }
			set { this.petsName = value; }
		}

		public int Hunger
		{
			get
			{
				return this.hunger;
			}
			set
			{
				this.hunger = value;
				if (this.hunger < 0)
				{
					this.hunger = 0;
				}
				if (this.hunger > 100)
				{
					this.hunger = 100;
				}
			}

		}
		public int Thirst
		{
			get { return this.thirst; }

			set
			{
				this.thirst = value;
				if (this.thirst < 0)
				{
					this.thirst = 0;
				}
				if (this.thirst > 100)
				{
					this.thirst = 100;
				}
			}
		}

		//public int BathroomNeed
		//{
		//	get { return this.bathroomNeed; }

		//	set
		//	{
		//		this.bathroomNeed = value;
		//		if (this.bathroomNeed < 0)
		//		{
		//			this.bathroomNeed = 0;
		//		}
		//		if (this.bathroomNeed > 100)
		//		{
		//			this.bathroomNeed = 100;
		//		}
		//	}
		//}

		public int Energy
		{
			get { return this.energy; }

			set
			{
				this.energy = value;
				if (this.energy < 0)
				{
					this.energy = 0;
				}
				if (this.energy > 100)
				{
					this.energy = 100;
				}
			}
		}
		public int Affection
		{
			get { return this.affection; }

			set
			{
				this.affection = value;
				if (this.affection < 0)
				{
					this.affection = 0;
				}
				if (this.affection > 100)
				{
					this.affection = 100;
				}
			}
		}

		//public double PetHappiness //this property takes the average of the virtual puppy's needs and subtracts it from 100 to get the pet's level of happiness. It will be used in main to determine the end of the game. 
		//{
		//	get { return 100 - ((this.Hunger + this.Thirst + this.BathroomNeed + this.Affection + this.Energy) / 5); }

		//}


		public void GetStatus()
		{
			Console.WriteLine("{0}  the virtual pets are:", this.PetsName);
			Console.WriteLine("\t {0}% hungry.", this.Hunger);
			Console.WriteLine("\t {0}% thirsty.", this.Thirst);
			Console.WriteLine();
		}

		//DECLARING METHODS

		public void FeedPet()
		{
			this.Hunger -= 50;
			this.Thirst += 30;
			Console.WriteLine("{0} says, \"You have fed the pets!\"", this.PetsName);
		}

		public void WaterPet()
		{
			this.Thirst -= 80;
			Console.WriteLine("{0} says, \"You have watered the pets!\"", this.PetsName);
		}

		public void PlayWithPet()
		{
			this.Energy -= 60;
			this.Affection -= 60;
			Console.WriteLine("{0} says, \"you played with (0)!\"", this.PetsName);
		}

	}//CLASS
}//NAMESPACE


//VirtualPet class
//For this week's VirtualPet, you can keep the class from last week's project and add the following, or create a new class with the following:
//•	  The VirtualPet class MUST include instance variables(fields/Properties) representing:
//o name
//o description
//•	  The VirtualPet class MUST include a constructor that accepts a name and description only
//•	  The VirtualPet class MUST include a constructor that, in addition to name and description, accepts starting values for the pet's attributes (hunger, boredom, etc).
//Remember that it is OK to have more than one constructor.This will be called an overloaded constructor
