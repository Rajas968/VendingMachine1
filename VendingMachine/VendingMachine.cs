using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
   public class VendingMachine
    {
        public double depositAmount;
        private double Remain_amount;
        const int COST_OF_COLA = 1;
        const double COST_OF_CHIPS = 0.50;
        const double COST_OF_CANDY = 0.65;
        public int _Cola, _Candy, _Chips;

        public bool InsertCoin { get; private set; }

        public VendingMachine()
        {
            depositAmount = 0;
            _Cola = 20;
            _Candy = 15;
            _Chips = 25;
        }
        public void DepositCoin(int coinAmount) // deposit the amount of coins
        {
            if (coinAmount < 0)
            {
                Console.WriteLine("Machine wont accept below then 1 cent");
            }
            else { depositAmount += coinAmount; }
        }
        public void GetProduct(string item, int itemQuantity) //Get the product of an item requested by user
        {
            if (item.Equals("Cola"))
            {
                if (depositAmount >= (COST_OF_COLA * itemQuantity))
                {
                    Remain_amount = depositAmount - (COST_OF_COLA * itemQuantity);
                    Console.WriteLine("Please take the item of COLA and remaining amount is  $" + Remain_amount);
                    Console.WriteLine("Thank you");
                    if (Remain_amount == 0)
                    {
                        depositAmount = 0;
                    }
                    else { depositAmount -= Remain_amount; }
                    
                    _Cola -= itemQuantity;
                    InsertCoin = false;
                }
                else
                {
                    InsertCoin = true;
                    Console.WriteLine("Insert more coins");
                }
            }
            else if (item.Equals("Chips"))
            {
                if (depositAmount >= (COST_OF_CHIPS * itemQuantity))
                {
                    Remain_amount = depositAmount - (COST_OF_CHIPS * itemQuantity);
                    Console.WriteLine("Please take the item of CHIPS packet and remaining amount is  $" + Remain_amount);
                    Console.WriteLine("Thank you");
                    if (Remain_amount == 0)
                    {
                        depositAmount = 0;
                    }
                    else { depositAmount -= Remain_amount; }
                    _Chips -= itemQuantity;
                    InsertCoin = false;
                }
                else
                {
                    InsertCoin = true;
                    Console.WriteLine("Insert more coins");
                    return;
                }
            }
            else if (item.Equals("Candy"))
            {
                if (depositAmount >= (COST_OF_CANDY * itemQuantity))
                {
                    Console.WriteLine("Please take the item of CANDY and remaining amount is  $" + Remain_amount);
                    Console.WriteLine("Thank you");
                    if (Remain_amount == 0)
                    {
                        depositAmount = 0;
                    }
                    else { depositAmount -= Remain_amount; }
                    _Candy -= itemQuantity;
                    InsertCoin = false;
                }
                else
                {
                    InsertCoin = true;
                    Console.WriteLine("Insert more coins");
                    return;
                }
            }
        }

        internal int GetInventoryofItem(string Itemcode) // storing the inventory of an item
        {
            if (Itemcode == "001")
            {
                return _Cola;
            }
            else if(Itemcode == "002")
            {
                return _Chips;
            }
            else
            {
                return _Candy ;
            }
        }

        public void GetRefund()
        {
            Console.WriteLine("Your refund amount is:-  $" + depositAmount);
            depositAmount = 0;
        }
    }
}
