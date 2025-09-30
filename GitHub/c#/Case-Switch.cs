// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class caseSwitch
{
    
    public static void Main(string[] args)
    {   Console.WriteLine ("What is your favourite fruit?");
        Console.WriteLine ("1: Banana");
        Console.WriteLine ("2: Orange");
        Console.WriteLine ("3: Apple");
        Console.WriteLine ("4: Apricot");
        Console.WriteLine ("5: Lemon");
        int x;
        x=Int16.Parse(Console.ReadLine());
        
        switch(x){
            case 1:
            Console.WriteLine ("You like bananas");
            break;
             case 2:
            Console.WriteLine ("You like oranges");
            break;
             case 3:
            Console.WriteLine ("You like apples");
            break;
             case 4:
            Console.WriteLine ("You like apricot");
            break;
             case 5:
            Console.WriteLine ("You like lemons");
            break;
            
         
        }
        
    }
}