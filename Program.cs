using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {


        static void Main(string[] args)
        {
            CreateContact contact = new CreateContact();
            
        ReEnteringApp:
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to view all the contacts in Address book.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();
                    break;
                case 2:
                    contact.ListPeople();
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;
        }
    }

}
    

        


    

          
    
            
          

        
         
      


