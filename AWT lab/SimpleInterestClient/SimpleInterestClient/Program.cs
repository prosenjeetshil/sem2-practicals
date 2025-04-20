using System;
using SimpleInterestClient.SimpleInterestWCFService;

namespace SimpleInterestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create proxy
            Service1Client client = new Service1Client();

            // Input
            double principal = 1000.0;
            double rate = 5.0;
            double time = 2.0;

            // Call service
            double interest = client.CalculateSimpleInterest(principal, rate, time);

            // Output
            Console.WriteLine($"Principal: {principal}, Rate: {rate}, Time: {time}");
            Console.WriteLine($"Simple Interest: {interest}");

            client.Close();
            Console.ReadLine();
        }
    }
}
