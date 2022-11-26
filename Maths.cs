using System;



static class Maths
{
    

static void MinNum(int num01,int num02)
{
            if(num01<num02){
                Console.WriteLine("Minimum number is "+num01);
            }
            else{
                Console.WriteLine("Mininmum number is "+num02);
            }
}
static void MaxNum(int num01,int num02)
{
           if(num01>num02){
                Console.WriteLine("Maximum number is "+num01);
            }
            else{
                Console.WriteLine("Maximum number is "+num02);
            }
}
 static long GetFactorial(int number)

        {          

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number-1);

        }
static void Sort(int[] input)
{
    for (var i = 0; i < input.Length; i++)
    {
        var min = i;
        for(var j = i + 1; j < input.Length; j++) { 
            if(input[min] > input[j])
            {
                min = j;
            }
        }

        if(min != i)
        {
            var lowerValue = input[min];
            input[min] = input[i];
            input[i] = lowerValue;
        }
    }
}





public static void Main(string[] args)
{  
    Console.Title = "Friday";
    int choice;
    Console.WriteLine("---Operations---\n1.Mininum number\n2.Maximum number\n3.Factorial\n4.Sort");
    choice = Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1:
            int num01;
            int num02;
            Console.WriteLine("Input a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            MinNum(num01,num02);
            break;
        case 2: 
           Console.WriteLine("Enter a number: ");
           num01 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter a second number: ");
           num02 = Convert.ToInt32(Console.ReadLine());
           MaxNum(num01,num02);
            break;
        case 3: 
           Console.WriteLine("Enter a number");
           int number = Convert.ToInt32(Console.ReadLine());
           long fact = GetFactorial(number);
           Console.WriteLine("{0} factorial is {1}", number, fact); 
            break;
        case 4: 
            Console.WriteLine("Enter the lenght of the array: ");
            int arraycount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of array: ");

            int[] array = new int[arraycount];
            for (int i = 0; i < arraycount; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array);
            Console.WriteLine("Sorted array of elements: ");
            for (int i = 0; i < arraycount; i++)
            {
                Console.WriteLine(array[i]);
            }
           
            break;
        default:
            Console.Write("Invalid choice.");
            break;
     }
      Console.ReadKey();
    
}
}


   