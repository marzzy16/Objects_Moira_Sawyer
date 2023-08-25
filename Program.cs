// See https://aka.ms/new-console-template for more information


using Objects_Moira_Sawyer;
{
    // a new Computer object and pass through needed arguments.
    Computer myComputer = new Computer("Apple", "All-in-one", true);
    IBootUp myBootUp = myComputer;
    Console.WriteLine(myComputer.Equals(myBootUp));

    //another Computer object that is assigned to the same values'
    Computer myOtherComputer = new Computer("Apple", "All-in-one", true);
    Console.WriteLine(myOtherComputer.Equals(myOtherComputer));

    // Compares the two obects.
    string myString = myComputer.ToString();
    string myOtherString = myString;

    // prints "Hi" to console.
    myString = "Hi!";

    //print the results to console.
    Console.WriteLine(myString);
    Console.WriteLine(myOtherString);

    //  compares the string variable to the object using ToString to print the results to console.
    Console.WriteLine(myString == myComputer.ToString());
    Console.WriteLine(myString == myOtherComputer.ToString());

    // calls the GetType method on a computer object and prints the results to console.
    Console.WriteLine(myComputer.GetType());
    Console.WriteLine(myBootUp.GetType());

    //Turns on or off one of the computer objects by calling the PowerOnOff method.
    myOtherComputer.PowerOnOff();


    Console.WriteLine(myString == myOtherComputer.ToString());
    Console.WriteLine(myString);
    Console.WriteLine(myOtherComputer.ToString());

    //if the string variable contains the letter "i", it print the results to console.
    Console.WriteLine(myString.Contains('i'));

    // Call ToUpper on the string variable and print the results.
    Console.WriteLine(myString.ToUpper());
   
}
