using System;
/*
NAME: OGUNNAIKE USMAN OLUSEGUN
MATRIC NO: EES/18/19/0377
ELECT /ELECT


*/

namespace ini
{
    class Program
    {
       public static void Main(string[] args)

        {
             string student;
             string course;

            Console.WriteLine("enter if you are a partime or fulltime");
           
            student = Convert.ToString(Console.ReadLine());  

            if (student == "fulltime")
            {
                Console.WriteLine( "enter your course of study");
                course = Console.ReadLine();
                Console.WriteLine(course+" is a good course");
            }
          if (student == "partime")
            {
                

          


             Console.WriteLine("how many credit are you taking?");
               
            
            
              int credit;
              credit = Convert.ToInt32(Console.ReadLine());
            

             if (credit > 6)
             {
            
                Console.WriteLine( "too much unit for a part-time student");
             }

            

              else {
            
                Console.WriteLine( "proceed");
              }

            }
        }
        

    }

            
}        
            



            
             
            

             
           
            
             
            
        
    

