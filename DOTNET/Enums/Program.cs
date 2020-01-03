using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[4];
            customers[0] = new Customer()
            {
                Name = "Manish",
                Gender = 1,
                GenderWithEnum=Gender.Male
                
            };
            customers[1] = new Customer()
            {
                Name = "Ramesh",
                Gender = 1,
                GenderWithEnum = Gender.Male
            };
            customers[2] = new Customer()
            {
                Name = "Akila",
                Gender = 2,
                GenderWithEnum = Gender.Female
            };
            customers[3] = new Customer()
            {
                Name = "Manisha",
                Gender = 0,
                GenderWithEnum = Gender.Unknown
            };

            foreach(Customer c in customers)
            {
                Console.WriteLine("Customer Name = {0}, and Gender = {1}", c.Name, GetGender(c.Gender));
                //even after implementing the getGender Method, the program is not readable.
                // as the program grows, dealing with interger forms of geneder will become more and deficult.
            }
            Console.WriteLine();
            Console.WriteLine("the below is done using Enum");
            Console.WriteLine();
            foreach (Customer c in customers)
            {
                Console.WriteLine("Customer Name = {0}, and Gender = {1}", c.Name, GetGenderWithEnum(c.GenderWithEnum));
               
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 0-> Unknown
        /// 1-> Male
        /// 2-> Female
        /// </summary>
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0: return "Unknown";
                    
                case 1: return "Male";
                //break; //break is not required as return is used
                case 2: return "Female";
                default: return "Not Specified";

            }
        }

        static string GetGenderWithEnum(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown: return "Unknown";

                case Gender.Male: return "Male";
                //break; //break is not required as return is used
                case Gender.Female: return "Female";
                default: return "Not Specified";

            }
        }



    }

    //Let create an enum to resolve this problem
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }


    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        
        // how enum to be used in class customer
        public Gender GenderWithEnum { get; set; }
    }
}
