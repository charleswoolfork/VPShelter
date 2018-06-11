using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{

	public abstract class Employee
	{

		public int ClockIn { get; set; }
		public int ShowID { get; set; }

		public abstract void clockIn();
		


		public abstract void showID();


	

		





	}
}
//The application MUST contain an Employee base class.
//	  The Employee class MUST contain one property(e.g.EmployeeID).
//	  The Employee class MUST contain two abstract methods.


//Employee Classes
//•	  The Employee base class MUST include: - [ ] One property(perhaps EmployeeID). - [ ] Two abstract methods(for example, ClockIn() or ShowID()).
