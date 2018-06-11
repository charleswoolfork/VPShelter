using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
	class Manager : Employee
	{
		public string PetsName { get; set; }

		public string AdoptAPet
		{
			get { return this.AdoptAPet; }
			set { this.PetsName = value; }
		}

		public override void clockIn()
		{
			throw new NotImplementedException();
		}

		public override void showID()
		{
			throw new NotImplementedException();
		}
	}

}
//The application MUST contain a Manager class derived from Employee.
//	  The Manager class MUST contain an override method.
//	  The Manager class MUST contain an additional property.
//	  The Manager class MUST contain a method for adopting a pet.
