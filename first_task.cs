// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        // This is the main entry point of the application.
        
        Console.WriteLine("Please enter the number of small carpets");
       
       int small_carpets= Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("Please enter the number of large carpets");
       
       int large_carpets= Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("Please enter the price of each small carpets");
       
       int small_carpets_price= Convert.ToInt32(Console.ReadLine());   
        Console.WriteLine("Please enter the priice of each large carpets");
       
       int large_carpets_price= Convert.ToInt32(Console.ReadLine());   
        float tax=0.125f; // 12.5% tax  
        double total_price = (small_carpets * small_carpets_price + large_carpets * large_carpets_price) *(1+tax) ;
        Console.WriteLine($"The total price of the carpets is {total_price}");
        // Wait for user input before closing the console window.
    }
}