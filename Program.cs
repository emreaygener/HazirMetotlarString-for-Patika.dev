using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string değişken = "Dersimiz CSharp, Hoşgeldiniz!";
            string değişken2 = "dersimiz csharp, hoşgeldiniz!";
            string değişken3 = "CSharp";
            
            // Length;
            Console.WriteLine(değişken.Length);

            // ToUpper, ToLower;
            Console.WriteLine(değişken.ToUpper());
            Console.WriteLine(değişken.ToLower());

            // Concat;
            Console.WriteLine(string.Concat(değişken,"Merhaba!"));

            // Compare,CompareTo
            Console.WriteLine(değişken.CompareTo(değişken2)); //0, 1 yada -1 döndürebilir.
            Console.WriteLine(string.Compare(değişken,değişken2,true)); 
            Console.WriteLine(string.Compare(değişken,değişken2,false)); 

            // Cotains
            Console.WriteLine(değişken.Contains(değişken3)); 
            Console.WriteLine(değişken.EndsWith("Hoşgeldiniz!")); 
            Console.WriteLine(değişken.StartsWith("Merhaba!")); 

            // IndexOf
            Console.WriteLine(değişken.IndexOf("CS")); 
            Console.WriteLine(değişken.IndexOf("Emre")); 
            Console.WriteLine(değişken.LastIndexOf("i")); 

            // Insert
            Console.WriteLine(değişken.Insert(0,"Merhaba! ")); 

            // PadLeft, PadRight;
            Console.WriteLine(değişken+değişken3.PadLeft(30)); 
            Console.WriteLine(değişken+değişken3.PadLeft(30,'*')); 
            Console.WriteLine(değişken.PadRight(50)+değişken3); 
            Console.WriteLine(değişken.PadRight(50,'-')+değişken3);  

            // Remove
            Console.WriteLine(değişken.Remove(10));  
            Console.WriteLine(değişken.Remove(5,3));  
            Console.WriteLine(değişken.Remove(0,1));  

            // Replace
            Console.WriteLine(değişken.Replace("CSharp","C#"));  
            Console.WriteLine(değişken.Replace(" ","*"));  

            // Split
            Console.WriteLine(değişken.Split(' ')[1]);  

            // Substring
            Console.WriteLine(değişken.Substring(4));  
            Console.WriteLine(değişken.Substring(4,6));  

        }
    }
}
