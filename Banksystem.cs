using System;
using TestAccount;
namespace BankSystem
{

    enum MenuOption
    {
        Withdraw = 1,
        Deposit,
        Print ,
        Quit  
    }
    class BankSystem
    {
        static MenuOption ReadUserInput()
        {
            int input;
            do
            {
                Console.WriteLine("\nWelcome user!\n");
                Console.WriteLine("To:\n1 Withdraw enter'1'\n2)Deposit enter'2'\n3)Print enter'3'\n4)Quit enter'4' ");
                Console.WriteLine("Enter choice: ");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < 1 || input > 4);
            MenuOption option = (MenuOption)input;
            return option;
        }


        static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter the amount you want to withdraw:");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            if (account.Withdraw(amount))
            {
                Console.WriteLine("Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Balance Not sufficient");
            }
        }

        static void DoDeposit(Account account)
        {
            Console.WriteLine("enter the amount you want to deposit:");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            if (account.Deposit(amount))
            {
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Error! depossit unsuccessful! amount entered is invalid!");
            }
        }


        static void Print(Account account)
        {
            account.Print();
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Name of account for which you want Transaction: ");
            string n = Console.ReadLine();
            Console.WriteLine("Enter balance in your account: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Account acc = new Account(b, n);
            MenuOption option = ReadUserInput();
            Console.WriteLine("YOU SELECTED TO " + option + "\n" + " To Change enter '1' else enter '0' :");
            int confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                option = ReadUserInput();
                Console.WriteLine("YOU SELECTED TO" + option + "\n");
            }
          

            switch (option)
            {
                case MenuOption.Withdraw:
                    {
                        DoWithdraw(acc);
                        break;
                    }
                case MenuOption.Deposit:
                    {
                        DoDeposit(acc);
                        break;
                    }
                case MenuOption.Print:
                    {
                        Print(acc);
                        break;
                    }
                case MenuOption.Quit:
                    {
                        break;
                    }
            }
        }
    }


}
