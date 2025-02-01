namespace ConsoleApp1;

class Main
{
    static void Main()
    {
        Dictionary<string, string> reservationData = new Dictionary<string, string>();
        
        Console.WriteLine("BOOKING PREFERENCE");
        Console.WriteLine("1. Solo Traveler");
        Console.WriteLine("2. Couple / Pair");
        Console.Write("\nENTER SELECTION: ");
        
        string bookingPreference = Console.ReadLine() switch
        {
            "1" => "Solo Traveler",
            "2" => "Couple / Pair",
            _ => "Unknown Preference"
        };
        reservationData.Add("BookingPreference", bookingPreference);
        
        Console.WriteLine("\nGUEST INFORMATION\n");
        Console.Write("Full Name: ");
        reservationData.Add("Name", Console.ReadLine()?.Trim() ?? "Unknown Name");
        Console.Write("Email Address: ");
        reservationData.Add("Email", Console.ReadLine()?.Trim() ?? "No Email Provided");
        Console.Write("Phone Number: ");
        reservationData.Add("Phone", Console.ReadLine()?.Trim() ?? "No Phone Provided");
        Console.WriteLine("\nBED PREFERENCE");
        Console.WriteLine("King Size");
        Console.WriteLine("Queen Size");
        Console.WriteLine("Single Beds");
        Console.WriteLine("--------------------------------");
        Console.Write("Enter selection: ");
        reservationData.Add("BedPreference", Console.ReadLine()?.Trim() ?? "No Bed Selected");
        Console.Write("How many nights: ");
        reservationData.Add("Nights", Console.ReadLine()?.Trim() ?? "Until Dawn");
        
        Console.WriteLine("\nOUTPUT");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("HOTEL RESERVATION SYSTEM");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("\nGUEST INFORMATION\n");
        
        foreach (var data in reservationData)
        {
            Console.WriteLine($"{data.Key}: {data.Value}");
        }
    }
}
