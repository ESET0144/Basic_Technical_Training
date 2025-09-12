/*
Design a console-based Book Shop Management System that allows a shopkeeper to manage a
book and sales for a single customer. The system should add new book by specifying the title,
author, price, and quantity. It should allow shopkeeper to sell book to a customer by entering the
book title, quantity and customer name ensuring that sales do not exceed available stock and
updating the inventory accordingly. The program should present a menu-driven interface with
input validation and continue to accept commands until the user chooses to exit. The system
manages only one customer during a session.
using System;
*/
namespace Book_Store
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string book_name, book_author, book_name_sell, customer;
            int book_price, book_qty, book_qty_sell;
            char inventory, sell, sales_report;

            Console.WriteLine("Enter Book title : ");
            book_name = Console.ReadLine();
            Console.WriteLine("Enter Author : ");
            book_author = Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            book_price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Qty : ");
            book_qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book added successfully !!");

            Console.WriteLine("Do you want to see the inventory ? (y/n) :");
            inventory = Convert.ToChar(Console.ReadLine());

            if (inventory == 'y') 
            {

                Console.WriteLine("----------Book Inventory----------");
                Console.WriteLine("Title  Author  Price  Quantity");
                Console.WriteLine(book_name + "  " + book_author + "  " + book_price + "  " + book_qty);
            }

           
                Console.WriteLine("Enter Book title to sell : ");
                book_name_sell = Console.ReadLine();
                Console.WriteLine("Enter Qty to sell : ");
                book_qty_sell = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Enter customer Name : ");
                customer = Console.ReadLine();
                Console.WriteLine("Ok !! Sold " + book_qty_sell + " copies of " + book_name + " to " + customer );

                book_qty = book_qty - book_qty_sell;

         

            Console.WriteLine("Do you want to see the sales report ? (y/n) :");
            sales_report = Convert.ToChar(Console.ReadLine());

            if (sales_report == 'y')
            {


                Console.WriteLine("---------- Sales Report ----------");
                Console.WriteLine("Customer  Book  Quantity Amount");
                Console.WriteLine(customer + "  " + book_qty_sell + "  " + book_qty + "  " + book_price);

                Console.WriteLine("Thank you for choosing Book Management Service!!");



            }

        }
        


        /*
        static (int , int secondnumber, int result) Addition(int firstnumber, int secondnumber)
        {
            Console.WriteLine("Reached Addition method");
            sum = firstnumber + secondnumber;
            Console.WriteLine("The sum of {0} and {1} is :{2}", firstnumber, secondnumber, sum);
            return (firstnumber, secondnumber, sum);
        }
        */
    }
}
