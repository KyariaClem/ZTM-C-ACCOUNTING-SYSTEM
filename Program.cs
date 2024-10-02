// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Accounting System 1.0");

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
//Console.WriteLine("Welcome to the Accounting System 1.0");
// The accounting system should have a checking account and a premium account.
//Console.WriteLine("Do you want to open a Checking or Premium account ?");

//string accountQuestionAnswer = Console.ReadLine();
//CheckingAccount checkAccount1 = new CheckingAccount(100, 200);
//Console.WriteLine(checkAccount1.printBalance);
checkAccount1.Transfer = 200;
String accountTransferToAccount = checkAccount1.accountTransfer();
Console.WriteLine(accountTransferToAccount);
//Console.WriteLine("Do you want to open a Checking or Premium account ?");


// System Questions
// Welcome Questions
Console.WriteLine("Welcome ! what is your name ? ");
String systemName = Console.ReadLine();
Console.WriteLine($"Hello {systemName}, do you want  to open a checking account ?");


string yesAnswer = "yes";
string accountYesNoQuestion = Console.ReadLine();
String noAnswer = "no";
String accountNoQuestion = Console.ReadLine();
if(accountYesNoQuestion == yesAnswer) {
    Console.WriteLine("Awesome, you want to open a checking account how much do you want to deposit ?");
//     string inputAccountDeposit = Console.ReadLine();
// int accountDeposit = int.Parse(inputAccountDeposit);
// string inputAccountDeposit = Console.ReadLine();
//     Console.WriteLine("It worked !");
} else if (accountNoQuestion == noAnswer) {
    Console.WriteLine("Do you want to open a premium account ?");
} else {
    Console.WriteLine("Have a great day !");
};


string yesTransferAnswer = "yes";
string transferYesAnswer = Console.ReadLine();
string noTransferAnswer = "no";
string transferNoAnswer = Console.ReadLine();
if(transferNoAnswer == yesTransferAnswer) {
    Console.WriteLine("How much do you want to deposit ?");
}
// acccount type answer by user input
// string inputAccountType = Console.ReadLine();
// // bool accountType = bool.Parse(inputAccountType);
// Console.WriteLine($"Awesome, you want to open a {inputAccountType}, how much do you want to deposit ?");
string inputAccountDeposit = Console.ReadLine();
int accountDeposit = int.Parse(inputAccountDeposit);

CheckingAccount userAccountChecking = new CheckingAccount();
userAccountChecking.Deposit = accountDeposit;

// if(accountType) {
//     Console.WriteLine($"Congrats you have opened {inputAccountType}, you have deposited: ${userAccountChecking.Deposit}");
// } else {
//     Console.WriteLine($"Goodbye, {systemName}");
// };

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
double accountTransferAmount = Balance + Transfer;
    return ($"You have transfered {Transfer}, you balance is now: {accountTransferAmount} in your checking account, the remaning balance in your preimum account is:");
}
}

class PremiumAccount {
    private int _accountId; 
    private double _balance;

     private double _interest;


    private double _depoBalance;

    private double _transfer;


    // set up empty constructor
    public PremiumAccount()
    {
        
    }

    public PremiumAccount(int _accountId, double _balance, double interest, double depoBalance, double transfer)
    {
        _accountId = 100;
         _balance = 0;
         _interest = 0;
         _depoBalance = 9;
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
    get {return _transfer; }
    set{_transfer = value;}
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

// passing Reference types as parameters
/*   
Arguments are either:
    -pass-by-value
    -pass-by-reference

c# value types: struct, int, bool
    reference types: classes
-refernce types (classes) are passed as arguments
Defintions:
PASS-BY-VALUE:
 a COPY of a variable will be passed to the method
 PASS-BY-REFERENCE:
    Acesss to the variable will be passed to the method
Default in c# ?
        -PASS-BY-VALUE; means when we pass an instance of the class to a method, the mehtod receives a COPY of the REFERENCE


REF KEYWORD 
    What ?
        -PASS-BY-REFERENCE: ref 
    Where (Do we add the keyword) ?
        -In front of parameter and in front of variable calling
EXAMPLE:
    MethodParameters.ChangeName( ref person) <-- Us calling the mehthod with reference/ ref keyowrd will also be in front of the variable in the class 

CLASS:
    public class MethodParameters
    {
        public static void ChangeName(ref Person person)
        {
            person.Name ="Unknown"  <-- person refers to a class called person not listed
        }
    }

    How to use pass-by-reference ?:
        -Use REF keyword
*/

// EXCEPTION HANDLING
/*  
WHAT ?:
        -An event that happens during the execution of a .net application in an exception case
ALLOWS?: 
    - .NET developers to transfer control from place where errors occur to another where they are handled

SYNTAX:

    try 
    {
        // potentional exception throwing block
    }
    catch (Exception exception)
    {   
        // handling the exception
    }
    finally
    {
        // running always after the catch
    }
*/

// Arrays / collection types
/* 
-Set the size of arrays during intialzarion
- Different collection types, cany vary in size and edit

ARRAYS:
 -Can store multiple variables of the same type in an arrray
 SYNTAX:
 type[] array_name = new type[number of variables that will be in new array]
 EX: int[] array1 = new int[7];

 settting / acess postion in array: (REMEMBER POSITION NUMBERING STARTS AT 0 !)"
 = setting position 0 to 7:
 array1[0] = 7;

 -printing a specfic value fron array; use sqaure brackets when using console.writeline
 ex:
 Console.WriteLine(array1[0]);

 SECOND WAY IN CREATING ARRAY(ONLY WORKS IF YOU KNOW THE VALUES YOU WANT IN ARRAY):
 Syntax:
 int[] arrayname = new int[] {values, values, values};
EX:
int[] array2 = new int[] {7,8,9,34};

ADDITIONAL NOTES:
-can use var keyword to replace type when setting array up
EX:
var array2 = new
*/
