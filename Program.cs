using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Dictionary<string, int> toysSold = new Dictionary<string, int>() {
            //     {"Hot Wheels", 344},
            //     {"Legos", 763},
            //     {"Gaming Consoles", 551},
            //     {"Board Games", 298}
            // };
            // toysSold.Add("Bicycles", 87);

            // foreach(KeyValuePair<string, int> toy in toysSold)
            // {
            //     Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            // }


            // Next, create a list to hold stock purchases by an investor. The list will contain dictionaries.
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("USAA", "USAA");
            stocks.Add("APL", "Apple");
            stocks.Add("GE", "General Electric");
            // Add a few more of your favorite stocks


            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock


                From the three purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

                Replace the questions marks below with the correct types.
            */
            Dictionary<string, double> stockReport = new Dictionary<string, double>();
            // stockReport.Add (new Dictionary<string, double>(){ {"GE", 230.21} });

            /*
            Iterate over the purchases and record the valuation
            for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases) {

            {


                foreach (KeyValuePair<string, double> kvp in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?

                    // If it does, update the total valuation

                    // ContainsKey can be used to test keys before inserting
                    // them.
                    if (stockReport.ContainsKey("General Electric"))
                    {
                        Console.WriteLine("---");
                        Console.WriteLine("Need to update the total valuation");
                        Console.WriteLine($"of : { stocks[kvp.Key]}  ");
                        Console.WriteLine($" by amount: (kvp.Key/StockReport): {purchase[kvp.Key]}");
                        stockReport[stocks[kvp.Key]]+= purchase[kvp.Key];
                        // ($" by amount: (kvp.Key/StockReport): {purchase[kvp.Key]}");
                        // stockReport[].Value+= purchase[kvp.Key];
                    }

                    /*
                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                    else {
                        Console.WriteLine( $" looped through purchase Dictionary: {kvp.Key} ");
                        Console.WriteLine( $" i want to add  {stocks[kvp.Key]} to from stocks Dictionary to stockReport Dictionary");

                        Console.WriteLine( $" i want to add the purchase value: {purchase[kvp.Key]} ");
                        stockReport.Add(stocks[kvp.Key], purchase[kvp.Key]);
                        };

                    Console.WriteLine($" StockReport: {stockReport[stocks[kvp.Key]]}");
                }
            }

            }

            foreach(KeyValuePair<string, double> item in stockReport)
{
    Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
}

        }
    }
}
