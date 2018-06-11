using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
	class Volunteer : Employee
	{
		public override void clockIn()
		{
			throw new NotImplementedException();
		}

		public override void showID()
		{
			throw new NotImplementedException();
		}
		private Volunteer ActionTwo = new Volunteer();
		//public class Volunteer : Employee
		//{
		//	//feed all pets
		//	public override void clockIn()
		//	{
		//		throw new NotImplementedException();
		//	}

		//	public override void showID()
		//	{
		//		throw new NotImplementedException();
		//	}
		//}
	}
	

}




//The application MUST contain a Volunteer class derived from Employee.
//	  The Volunteer class MUST contain an override method.
//	  The Volunteer class MUST contain an additional property.
//	  The Volunteer class MUST contain a method for feeding all of the pets.
//	  The Volunteer class MUST contain a method for giving water to all of the pets.
