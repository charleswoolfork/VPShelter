using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter 
{



	public class VirtualPetShelter 
	{
		//instance vsariables
		string descriptionOfPet;
		string petOne;
		string petTwo;
		string petThree;
		string petFour;

		string employeeMgrJohn;
		string employeeMgrDavid;
		string employeeVolMary;
		string employeeVolGrace;


		public string PetList { get; set; }
		public string EmployeeList{ get; set; }
		public string DescriptionList { get; set; }

		public List<string> petList = new List<string>()
		{
			"petOne", "petTwo", "petThree", "petFour"
		};

		public List<string> employeeList = new List<string>()
		{
			"employeeMgrJohn", "employeeMgrDavid", "employeeVolMary", "employeVolGrace"
		};

		public List<string> descriptionList = new List<string>()
		{
			"Dog", "Cat", "Bird", "Hamster"
		};




	}

}
//The VirtualPetShelter class MUST contain Fields/Properties to store all of the pets and all of the employees. // LISTS


//VirtualPetShelter class
//•	  The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store the pets who reside at the shelter.
//•	  The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store all of the employees who volunteer or work at the shelter.
//•	HINT: Don't overthink this class. You might not instantiate an object from this class in your program. This class allows us to see your ability to appropriately use Lists.
