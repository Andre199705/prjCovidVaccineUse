using System;

namespace prjCovidVaccineUse
{
    class Program
    {

        
        static void Main(string[] args)
        {
            info i = new info();

            Console.WriteLine("Please enter the name of the Hospital");
            i.setHospital_Name(Console.ReadLine());

            Console.WriteLine("Is it a private or a public hospital ");
            i.setHospitalType(Convert.ToBoolean(Console.ReadLine()));

            Console.WriteLine("Please enter the hospital address");
            i.setAddress(Console.ReadLine());

            Console.WriteLine("In what province is the hospital situated");
            i.setProvince(Convert.ToChar(Console.ReadLine()));

            Console.WriteLine("In what province is the hospital situated");
            i.setArray(Convert.ToChar(Console.ReadLine()));

            Capture c = new Capture();
            c.getPatientDetails();

            printDetails p = new printDetails();


        }
    }
}
