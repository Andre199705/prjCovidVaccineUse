using System;

namespace prjCovidVaccineUse
{
    class Program
    {

        
        static void Main(string[] args)
        {

            info A = new info();
            Console.WriteLine("please enter wich hospital");
            A.setHospital_Name(Console.ReadLine());

            Console.WriteLine("please enter the address");
            A.setAddress(Console.ReadLine());

            Console.WriteLine("please indicate if it as a private or an public Hospital ");
            A.setHospital_Name(Console.ReadLine());
            //capture the info from the capture class
            Capture c = new Capture();
            c.addPerson();

            //Print all information that is inside the class 
            printDetails p = new printDetails();
            p.PrintItems();


        }
    }
}
