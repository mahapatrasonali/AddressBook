﻿using System;
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
        ReEnteringApp:                         //to repeating the complete process used label .
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to Edit/Modify any existing contact\n" +
                "Press 3 : to view all the contacts in Address book.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();        //Adding persom
                    break;
                case 2:
                    contact.EditPerson();       //Editing existing contact
                    break;
                case 3:
                    contact.ListPeople();       //viewing all contacts.
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;     //for repeatation of same task from start point have used goto control statement .
        }
    }
}
       
    

        


    

          
    
            
          

        
         
      


