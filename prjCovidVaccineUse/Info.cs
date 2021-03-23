using System;
using System.Collections.Generic;
using System.Text;


namespace prjCovidVaccineUse
{
	 class info

	{
		private static int iSizeArray = 0;
		private static int iCounter = 0;

		private static String strHospital_Name;
		private static String strAddress;
		private static bool bType;
		private static Char cProvince;

		public void setHospital_Name(String hospitalName)
        {
			strHospital_Name = hospitalName;
        }

		public String getHospital_Name()
        {
			return strHospital_Name;
        }

		public void setAddress(String address)
        {
			strAddress = address;
        }

		public String getAddress()
        {
			return strAddress;
        }

		public void setHospitalType(Boolean type)

        {
			bType = type;
        }
		
		public Boolean getHospitalType()
        {
			return bType;
        }

		public void setProvince(Char province)
        {
			cProvince = province;
        }

		public Char getProvince()
        {
			return cProvince;
        }

		private static String[] ID_Number;
		private static String[] MedicalAid;
		private static String[] Name;
		private static String[] Surname;
		private static String[] RefDr;
		private static Char[] BloodType;
		private static String[] Allergies;
		private static Boolean[] CovidPositive;
		private static String[] Vaccine;

		public void setArray(int num)
        {
			ID_Number = new string[num];
			MedicalAid = new string[num];
			Name = new string[num];
			Surname = new string[num];
			RefDr = new string[num];
			BloodType = new Char[num];
			Allergies = new string[num];
			CovidPositive = new Boolean[num];
			Vaccine = new string[num];
			iSizeArray = num;
		}

		public void addPerson(String strID,String strMedic, String strName, String strSurname, String strRefDr, Char cBloodType,
			String strAllergies, Boolean bCovid,String strVac)
        {
			ID_Number[iCounter] = strID;
			MedicalAid[iCounter] = strMedic;
			Name[iCounter] = strName;
			Surname[iCounter] = strSurname;
			RefDr[iCounter] = strRefDr;
			BloodType[iCounter] = cBloodType;
			Allergies[iCounter] = strAllergies;
			CovidPositive[iCounter] = bCovid;
			Vaccine[iCounter] = strVac;

			iCounter++;

		}

		public int size()
        {
			return iSizeArray;
        }

		public string getIDNumber(int x)
        {
			return ID_Number[x];
        }
		public string getName(int x)
        {
			return Name[x];
        }
		public String getSurname(int x)
        {
			return Surname[x];
        }

		public String getRefDr(int x)
        {
			return RefDr[x];
        }

		public Char getBloodType(int x)
        {
			return BloodType[x];
        }

		public String getAllergies(int x)
        {
			return Allergies[x];
        }
		public Boolean getBCovid(int x)
        {
			return CovidPositive[x];
        }
		public String getVaccine(int x)
        {
			return Vaccine[x];
        }





		/////done////
	}




	}

