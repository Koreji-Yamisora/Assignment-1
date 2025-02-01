# Introduction
The purpose of this assignment is to allow the customer to input booking hotel reservation data using these format

> [!NOTE] Example
> **HOTEL RESERVATION SYSTEM**
> 
> **BOOKING PREFERENCE** (Use if else condition)
> 
> 1. Solo Traveler
> 
> 2. Couple / Pair
> 
> **ENTER SELECTION: 1**
> 
>   
> 
> **GUEST INFORMATION**
> 
>   
> 
> Full Name: **John Wick**
> 
> Email Address: **john.wick@email.com**
> 
> Phone Number: **099999999**
> 
>   
> 
> **BED PREFERENCE** 
> 
> King Size
> 
> Queen Size
> 
> Single Beds
> 
> --------------------------------
> 
> Enter selection: **King Size**
> 
> How many nights: **2**
> 
>   
> 
> OUTPUT
> 
> **-----------------------------------------------------------**
> 
> **HOTEL RESERVATION SYSTEM**
> 
> **-----------------------------------------------------------**
> 
> **GUEST INFORMATION**
> 
>   
> 
> **Booking Preference: Solo Traveler**
> 
> **Stays per night: 2**
> 
> **Bed Preference: King Size**
> 
> **Full Name: John Wick**
> 
> **Email address: john.wick@email.com**
> 
> **Phone number: 099999999**

# The Program

### Code: 
	class Program  
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
## Explanation
Due to the purpose of the program I have thought to have some Data Structure to organize as an example for which can be expanded further into working Database
So I have chosen Dictionary as the key Data Structure because of {key, value} format which is very easy and intuitive to interact
I also use the null-coalescing operators to explain why data is missing and fixing issue with non-nullable variable