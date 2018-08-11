using System;

namespace names_and_methods
{
    internal class Program
    {
        public static (string FirstName, string LastName) BothNames { get; private set; }

        private static void Main(string[] args)
        {
            // ask the user to enter first and last name
        
            Console.WriteLine("First name + Last name");

            // ask the user whats his first name 
            Console.Write("Whats your First Name");
            string FirstName = Console.ReadLine();


            // ask the user whats his last name 
            Console.WriteLine("whats your Last Name");
            string LastName = Console.ReadLine();

            // combine both the firstname and the lastname
             Console.Write(string.Format("{0} {1}", FirstName, LastName));

            BothNames = (FirstName, LastName);


            Console.ReadLine();


        } 

}

    private static string BothNames(string FirstName, string LastName);

            private string Fullnames = ("FirstName + LastName");

       Return Fullname;
   
           

    }


       
        

       

