using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVaccineUse
{
	class Capture
	{
		public void getPatientDetails()
		{
			info i = new info();

			Console.Clear();

			for(int x = 0; x < i.size(); x++)
            {
                Console.WriteLine("Please enter the patient ID number: ");
				String ID_Number = Console.ReadLine();

                Console.WriteLine("Please enter the patient" + (x + 1) + "name: ");
				String Name = Console.ReadLine();

				Console.WriteLine("Please enter the patient Surname ");
				String Surname = Console.ReadLine();

				Console.WriteLine("Please enter the patient Medical Aid  ");
				String MedicalAid = Console.ReadLine();

				Console.WriteLine("Please enter the Docters name that will be treating the patient  ");
				String RefDr = Console.ReadLine();

                Console.WriteLine("Please enter the patient blood type");
				char BloodType = Convert.ToChar(Console.ReadLine());

				Console.WriteLine("Please enter the allergies of the patient ");
				String Allergies = Console.ReadLine();

				Console.WriteLine("Please enter if the patient is covid Positive (True/ False) :  ");
				Boolean CovidPositive  = Convert.ToBoolean( Console.ReadLine());

                Console.WriteLine("Please enter if the patient will be taking the vaccine ");
				String strVac = Console.ReadLine();


			}

		


				//Done

			}


		}
	}




