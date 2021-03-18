using System;

namespace prjCovidVaccineUse
{
    class Program
    {

        
        static void Main(string[] args)
        {
            info A = new info();
            //Prompting the user

            Console.WriteLine("please indicate if it as a private or an public Hospital ");
            A.setHospitalPUBPRIV(Console.ReadLine());

            
            Console.WriteLine("please enter wich hospital");
            A.setHospitalName(Console.ReadLine());

            Console.WriteLine("please enter the address");
            A.setAddress(Console.ReadLine());

            Console.WriteLine("In wich province is the Hospital");
            A.setProvince(Console.ReadLine());



            //capture the info from the capture class
            Capture c = new Capture();
            c.addPerson();

            //Print all information that is inside the class 
            printDetails p = new printDetails();
            p.PrintItems();


        }
    }
}
