using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVaccineUse
{
    class printDetails
    {
        public void PrintItems()
        {
            info i = new info();

            Console.Clear();

            Console.WriteLine("Hospital Name" + i.getHospital_Name());
            Console.WriteLine("Address" + i.getAddress());
            Console.WriteLine("Private or public " + i.getHospitalType()) ;

            for(int x=0; x <i.size(); x++)
            {
                Console.WriteLine("IDNUmber:{0}" +
                                   "\nPatient Name:{1}" +
                                   "\nPatient Surname:{2}" +
                                   "\nRefering Doctor:{3}" +
                                   "\nBloodtype:{4}" +
                                   "\nAllergies:{5}" +
                                   "\nHad Covid:{6}" +
                                   "\nGetting the vaccine:{7}" ,
                                   i.getIDNumber(x) , i.getName(x),i.getSurname(x),i.getRefDr(x),i.getBloodType(x),i.getAllergies(x),
                                   i.getBCovid(x),i.getVaccine(x));
            }

            Console.ReadLine();


         

            }








        }
    }

