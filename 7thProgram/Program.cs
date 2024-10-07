using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

#pragma warning disable
class Program
{
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        string ConsoleInput(string addingmessage)
        {
            Console.Write(addingmessage + " ");
            string? sentvar = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(sentvar))
            {
                Console.Write(addingmessage + " ");
                sentvar = Console.ReadLine();
            }
            return sentvar;
        }

        string fromCurrency = ConsoleInput("Convert From:").ToUpper();
        string toCurrency = ConsoleInput("Convert To:").ToUpper();
        decimal amount = Convert.ToDecimal(ConsoleInput("Amount to convert:"));

        decimal convertedAmount = await ConvertCurrency(fromCurrency, toCurrency, amount);
        Console.WriteLine($"{amount} {fromCurrency} is {convertedAmount} {toCurrency}");
    }

    private static async Task<decimal> ConvertCurrency(string from, string to, decimal amount)
    {
        try
        {
            string url = $"https://api.exchangerate-api.com/v4/latest/{from}";
            string responseBody = await client.GetStringAsync(url);
            JObject json = JObject.Parse(responseBody);

            if (json["rates"] == null)
            {
                Console.WriteLine("Error: Rates are not available. Please check the currency codes.");
                return 0;
            }

            var rateToken = json["rates"][to];
            if (rateToken != null)
            {
                decimal rate = (decimal)rateToken;
                return amount * rate;
            }
            else
            {
                Console.WriteLine($"Error: No rate found for {from} to {to}.");
                return 0;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return 0;
        }
    }
}
