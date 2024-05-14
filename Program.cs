// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("TEST");

// The following Features Should Be Implemented:
CheckingAccount checkAccount1 = new CheckingAccount();
checkAccount1.Balance = 800.50;
checkAccount1.AccountId = 100;
checkAccount1.Interest = 3;
Console.WriteLine(checkAccount1.Balance);
Console.WriteLine(checkAccount1.Interest);
// interest string
String ch1Interest = checkAccount1.addInterest();
Console.WriteLine(ch1Interest);

// balance string 
checkAccount1.Deposit = 400.50;

String addingtoCheckingAccount = checkAccount1.addBalance();

Console.WriteLine(addingtoCheckingAccount);

// Preimum account instances
PremiumAccount premiumAccount1 = new PremiumAccount();
premiumAccount1.Balance = 2000;
premiumAccount1.AccountId = 200;
premiumAccount1.Interest = 3;
Console.WriteLine(premiumAccount1.Balance);

// Adding interest to account string
String addingtoPremiuumAccount = premiumAccount1.addBalance();
Console.WriteLine(addingtoPremiuumAccount);
// Greet the user with a welcome message. Something like "Welcome to the Accounting System 1.0."
Console.WriteLine("Welcome to the Accounting System 1.0");
// The accounting system should have a checking account and a premium account.
//Console.WriteLine("Do you want to open a Checking or Premium account ?");

//string accountQuestionAnswer = Console.ReadLine();
//CheckingAccount checkAccount1 = new CheckingAccount(100, 200);
//Console.WriteLine(checkAccount1.printBalance);

//Console.WriteLine("Do you want to open a Checking or Premium account ?");
class CheckingAccount {

    private int _accountId; 
     private double _balance;

     private double _interest;



    private double _depoBalance;

    private double _transfer;

    //private PremiumAccount _premiumAccount;

    // set up empty constructor
    public CheckingAccount()
    {
        
    }

    public CheckingAccount(int _accountId, double _balance, double interest, double _depoBalance, double _transfer,PremiumAccount _premiumAccount )
    {
        _accountId = 100;
         _balance = 0;
         _interest = 3;
         _depoBalance = 0;
         _transfer = 0;
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

public double Balance {
    // for getter return field name
    // for setter field name = value keyword
get { return _balance;}
set {_balance = value;}
} 

public double Interest {

    get { return _interest;}
    set {_interest = value;}

}

public double Deposit {
    get {return _depoBalance; }
    set {_depoBalance = value;}
}

public double Transfer {
    get { return _transfer; }
    set {_transfer = value;}
}

// public PremiumAccount PremiumAccount {
//     get {return _premiumAccount; }
//     set {_premiumAccount = value; }
// }
// Add Balance method
public String addBalance() {
    double depositBalance = Deposit + Balance;
    return ($"You have deposited ${Deposit} into your checking account, your new account balance is: ${depositBalance}");
}
// Create method for adding interest
// call the getting setter name
public String addInterest() {
   double interestBalance = Interest * Balance / 100 + Balance;

    return ($"your interest is {Interest}% + your account balance: ${Balance} = ${interestBalance}");
}

// public void addInterest() {
//      Console.WriteLine($"your interest is {Interest} + your {Balance} = ");
// }

public String Test() {
    return "update to git hub";
}
// public  void printBalance() {
//     //Console.WriteLine($"Your account balance is {Balance}");
//     Console.WriteLine($"{Balance}");
// }


// method fr transfer in account
//DO NEXT !!
public String accountTransfer() {
double accountTransferAmount = Deposit + Transfer;
    return ($"You have transfered {Transfer}, you balance is now: {accountTransferAmount} in your checkimh account, the remaning balance in your preimum account is:");
}
}

class PremiumAccount {
    private int _accountId; 
    private double _balance;

     private double _interest;


    private double _depoBalance;


    // set up empty constructor
    public PremiumAccount()
    {
        
    }

    public PremiumAccount(int _accountId, double _balance, double interest, double depoBalance)
    {
        _accountId = 100;
         _balance = 0;
         _interest = 0;
         _depoBalance = 0;
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

public double Balance {
    // for getter return field name
    // for setter field name = value keyword
get { return _balance;}
set {_balance = value;}
} 

public double Interest {

    get { return _interest;}
    set {_interest = value;}

}

public double Deposit {
    get {return _depoBalance; }
    set {_depoBalance = value;}
}

public String addBalance() {
    double depositBalance = Deposit + Balance;
    return ($"You have deposited ${Deposit} into your premium account, your new account balance is: ${depositBalance}");
}
// Create method for adding interest
// call the getting setter name
public String addInterest() {
   double interestBalance = Interest * Balance / 100 + Balance;

    return ($"your interest is {Interest}% + your premium account balance: ${Balance} = ${interestBalance}");
}

}

// MAINTENACE NOTES

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