// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Let me tell you about my friends");
// string[] frendsName =   {"Nodir", " Toshkent" , "Ahmad"};
// int[] frendsAge = { 26, 25 , 24};
// Console.WriteLine($"{frendsName[0]} is {frendsAge[0]}");



//                     Basics.Takrorlash bo’limi uchun
//                               TASK1

// int counter = 0;
// int i = 1;

// while ( i < 100)
// {
//    if (i % 2 != 0)
//    {
//     counter +=i;
//    } 
//     i++;
// }

// Console.WriteLine(counter);


//                     Basics.Takrorlash bo’limi uchun
//                               TASK2

      //   int[] array = { 3, 7, 2, 8, 1, 4, 9 };


      //   int max = array[0];
      //   int min = array[0];

      //   for (int i = 1; i < array.Length; i++)
      //   {
      //       if (array[i] > max)
      //       {
      //           max = array[i]; 
      //       }

      //       if (array[i] < min)
      //       {
      //           min = array[i]; 
      //       }
      //   }

      //   int result = max * min;
      //   Console.WriteLine(result);



//                     Basics.Takrorlash bo’limi uchun
//                               TASK3


        Console.Write("Butun sonni kiriting (x): ");
        int x = int.Parse(Console.ReadLine());

       
        int factorial = 1;

        for (int i = 1; i <= x; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);