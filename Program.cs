// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("TEST");

// The following Features Should Be Implemented:
CheckingAccount checkAccount1 = new CheckingAccount(100, 200);
Console.WriteLine(checkAccount1.printBalance);


// Greet the user with a welcome message. Something like "Welcome to the Accounting System 1.0."
Console.WriteLine("Welcome to the Accounting System 1.0");
// The accounting system should have a checking account and a premium account.
//Console.WriteLine("Do you want to open a Checking or Premium account ?");

//string accountQuestionAnswer = Console.ReadLine();
//CheckingAccount checkAccount1 = new CheckingAccount(100, 200);
Console.WriteLine(checkAccount1.printBalance);

//Console.WriteLine("Do you want to open a Checking or Premium account ?");
class CheckingAccount {

    private int _accountId; 
     private int _balance;



    // set up empty constructor
    public CheckingAccount()
    {
        
    }

    public CheckingAccount(int _accountId, int _balance)
    {
        _accountId = 100;
         _balance = 0;
    }
// Properties
// Use Capitalzed name for property name
// 
public int AccountId {
    // for getter return field name
    // for setter field name = value keyword
get { return _accountId;}
set {_accountId = value;}
} 

public int Balance {
    // for getter return field name
    // for setter field name = value keyword
get { return _balance;}
set {_balance = value;}
} 
public  void printBalance() {
    Console.WriteLine($"Your account balance is {_balance}");
}
}

class PremiumAccount {
    private int _accountId; 
    private int _balance;

}



// A checking account has an ID (number) and a balance (decimal number).

// You should be able to set a starting balance when creating a checking account.

// You should be able to deposit money (decimal number) at any time after creating a checking account.

// You should be able to calculate interest based on the current balance of the checking account and an input.

// You should be able to print the ID and the current balance of a checking account at any time.

// The premium account has the same behavior as the checking account. The only difference is that the premium account gets a 1% extra interest on top of the user input.

// You should be able to transfer money from one account to another at any time.

// The program should execute the following operations in order:

// Print the welcome message.

// Create a checking account with an ID of 100 and starting balance of 0.

// Create a premium account with an ID of 200 and starting balance of 0.

// Print the balance of both accounts.

// Deposit 2000 to the checking account.

// Deposit 6000 to the premium account.

// Print the balance of both accounts.

// Transfer 2000 from the premium account to the checking account.

// Print the balance of both accounts.

// Calculate the interest for both accounts based on a 3% interest rate.

// Print the interest for both accounts.

// Print the balance of both accounts after adding the interest to the accounts.