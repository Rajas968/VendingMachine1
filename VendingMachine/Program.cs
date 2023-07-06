using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            int Coins = 0;
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Cola {0}, Chips : {1}, Candy:{2}", vendingMachine._Cola, vendingMachine._Chips,vendingMachine._Candy); // Displaying the Inventory of each Product
            Console.WriteLine("Cola {0}, Chips: {1}, Candy:{2}", " : $1", " : $0.5", " :$0.65"); // Displaying the prices of Products
        start:
            try
            {
                if (vendingMachine.depositAmount <= 0 || vendingMachine.InsertCoin == true) 
                {
                    Console.WriteLine("Please insert the coins :-  ");
                    Coins = Convert.ToInt32(Console.ReadLine());
                    vendingMachine.DepositCoin(Coins);
                }

                Console.WriteLine("Please enter the item code here, ---- Cola {0}, Chips: {1}, Candy:{2}", "001", "002", "003"); // asking user to enter codes for product
                string code = Console.ReadLine();
                Console.WriteLine("Enter the quantity");
                int ItemQuantity = Convert.ToInt32(Console.ReadLine());
                if (code == "001")
                {
                    int productcount = Convert.ToInt32(vendingMachine.GetInventoryofItem(code)); // getting the inventory count of a product
                    if (productcount >= ItemQuantity)
                    {
                        vendingMachine.GetProduct("Cola", ItemQuantity);
                        // vendingMachine.GetRefund(); // if we uncommect this line then deposit amount will  become zero after dispense the product to customer
                    }
                    else { Console.WriteLine("There is no inventory of COLA in the Vending Machine"); }

                }
                else if (code == "002")
                {
                    int productcount = Convert.ToInt32(vendingMachine.GetInventoryofItem(code));
                    if (productcount >= ItemQuantity)
                    {
                        vendingMachine.GetProduct("Chips", ItemQuantity);
                        //vendingMachine.GetRefund(); // if we uncommect this line then deposit amount will  become zero after dispense the product to customer
                    }
                    else { Console.WriteLine("There is no inventory of Chips in the Vending Machine"); }
                }
                else if (code == "003")
                {
                    int productcount = Convert.ToInt32(vendingMachine.GetInventoryofItem(code));
                    if (productcount >= ItemQuantity)
                    {
                        vendingMachine.GetProduct("Candy", ItemQuantity);
                        //vendingMachine.GetRefund(); // if we uncommect this line then deposit amount will  become zero after dispense the product to customer
                    }
                    else { Console.WriteLine("There is no inventory of Candy in the Vending Machine"); }
                }
                else
                {
                    Console.WriteLine("No inventory found for this Product");
                }

                Console.WriteLine("Cola {0}, Chips: {1}, Candy:{2}", vendingMachine._Cola, vendingMachine._Chips, vendingMachine._Candy);
                Console.ReadLine();
                goto start;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
