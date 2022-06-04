using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniprojectStudentmanagement
{
	interface IUserinterface
	{
		void showFirstScreen();
		void showStudentScreen();
		void showAdminScreen();
		void showAllStudentsScreen();
		void showStudentRegistrationScreen(); 
		void introduceNewCourseScreen();
		void showAllCoursesScreen();
	}
}