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
              Console.WriteLine("Welcome to the Address Book System Problem.");
            CreateContact contact = new CreateContact()
            {

                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt64(Console.ReadLine()),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
                
             };
            
           Console.WriteLine("Contact Details : " + "\n" + "First Name : " + contact.FirstName + "\n" + "Last Name : " + contact.LastName  + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State  + "\n" + "Zip is : " + contact.Zip  + "\n" + "Phone Number is :" + contact.PhoneNumber + "\n" + "Email is : " + contact.Email);
        }
    }
}
        
         
      


