using System;


namespace ClassLibrary01
{
    public class Class1
    {

        int i;

        public int SUM(int a,int b) 
        {
            i = a + b;
            Console.WriteLine("First Number of Sum is "+ a +" And Second Number of Sum Is "+b);
            return i; 
        }

        public void Display(string msg)
        {
            Console.WriteLine("Your Display Message From Console App is :- "+ msg);
        }
    }
}