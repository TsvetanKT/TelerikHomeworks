namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GsmTest
    {
        /*
            Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
        battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
            Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
        Define several constructors for the defined classes that take different sets of arguments (the full information for 
        the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). 
        All unknown data fill with null.
            Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
            Add a method in the GSM class for displaying all information about it. Try to override ToString().
            Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data 
        at any given time.
            Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
            Write a class GSMTest to test the GSM class:
            -Create an array of few instances of the GSM class.
            -Display the information about the GSMs in the array.
            -Display the information about the static property IPhone4S.
        
            Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
            Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
            Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
            Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
        
        Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.
         */
        public static void Main()
        {
            //Initial price per minute
            decimal PricePerMinute = 0.37m;

            GSM phone1 = new GSM("Lumia 520", "Nokia");
            GSM phone2 = new GSM("Galaxy S4", "Samsung", 789.00m);
            GSM phone3 = new GSM("Nexus 5 D821", "LG", 695.00m, "Joe Cocker",
                new Battery("AM-3G", 330.0, 11.5, BatteryType.LiIon),
                new Display(5.0, "16M"));

            GSM[] phones = new GSM[] { phone1, phone2, phone3 };

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine(GSM.Iphone4S);
            Console.WriteLine(new string('-', 50));

            GSM anotherGsm = phone3;

            anotherGsm.AddCall(new Call(DateTime.Now, "+359881234567", 224));
            anotherGsm.AddCall(new Call(new DateTime(2014, 01, 29, 18, 53, 11), "+359897878788", 96));
            anotherGsm.AddCall(new Call(new DateTime(2014, 01, 20, 22, 44, 17), "+359895555555", 187));

            // printing info about the calls
            Console.WriteLine("Logs of dialed numbers: ");

            foreach (var call in anotherGsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            // Cost of all calls          

            decimal totalCost = anotherGsm.CalculatePrice(PricePerMinute);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Total cost of all the calls: {0}", totalCost);

            // Longest call
            int longest = int.MinValue;
            Call targetCall = null;

            foreach (var call in anotherGsm.CallHistory)
            {
                if (call.Duration > longest)
                {
                    longest = call.Duration;
                    targetCall = call;
                }
            }

            anotherGsm.DeleteCall(targetCall);

            totalCost = anotherGsm.CalculatePrice(PricePerMinute);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Total cost of the calls after removing longest one: {0}", totalCost);

            // Clearing and printing the call history
            List<Call> deleted = anotherGsm.ClearCallHistory();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Call history after deleting:");

            foreach (var call in deleted)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine();
        }
    }
}