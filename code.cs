using System;  
  public class Assignment
   {  
     public static void Main(string[] args)  
      {  
       int a;
       int b;
       Console.WriteLine("Please give a number as 1st variable:");
       a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Please give a number as 2nd variable:");
       b = Convert.ToInt32(Console.ReadLine()); 
       a=a+b;       
       b=a-b;       
       a=a-b;     
       Console.Write("The value of the 1st variable: " + a + "\n");    
       Console.Write("The value of the 2nd variable: " + b);
      }  
  }