using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVaccineUse
{
    class printDetails
    {
        public void PrintItems()
        {



            info A = new info();

            Console.Clear();

            Console.WriteLine("Hospital name " + A.getHospital_Name());
            Console.WriteLine("Hospital name " + A.getAddress());
            Console.WriteLine("Hospital name " + A.getHospitalPUBPRIV());
         
            for (int x = 0; x < A.size(); x++)
            {
                Console.WriteLine("ID Number : {0}" + A.getIDNumber(x) +
                    "\nMedical Aid: {1} " + A.getMedicalAid(x) +
                     "\nName: {2} " + A.getName(x) +
                      "\nSurname: {3} " + A.getSurname(x) +
                       "\nRefering Dr: {4} " + A.getRefDr(x) +
                        "\nAllergies: {5} " + A.getAllergies(x) +
                         "\nHad covid: {6} " + A.getCovidPostive(x) +
                          "\nVaccine brand : {7} " + A.getVaccine(x));


                         // , A.getIDNumber(x), A.getMedicalAid(x), A.getName(x), A.getSurname(x),
                         // A.getRefDr(x), A.getAllergies(x), A.getCovidPostive(x), A.getVaccine(x));






            }








        }
    }
}
