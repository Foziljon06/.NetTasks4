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


      //   Console.Write("Butun sonni kiriting (x): ");
      //   int x = int.Parse(Console.ReadLine());

       
      //   int factorial = 1;

      //   for (int i = 1; i <= x; i++)
      //   {
      //       factorial *= i;
      //   }

      //   Console.WriteLine(factorial);



              //   Basics.Takrorlash bo'limi uchun 2-amaliy vazifa


//                               TASK 1

using System;

class Program
{
    static void Main(string[] args)
    {
        // Vazifalar ro'yxati
        string[] tasks = new string[100];
        bool[] isCompleted = new bool[100];
        int taskCount = 0;

        while (true)
        {
            // Asosiy menyu
            Console.WriteLine("\nVazifalar boshqaruvi:");
            Console.WriteLine("1. Vazifa qo'shish");
            Console.WriteLine("2. Vazifani o'chirish");
            Console.WriteLine("3. Vazifani bajarilgan deb belgilash");
            Console.WriteLine("4. Vazifalar ro'yxatini ko'rish");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlovni kiriting: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks, isCompleted, ref taskCount);
                    break;

                case "2":
                    DeleteTask(tasks, isCompleted, ref taskCount);
                    break;

                case "3":
                    MarkTaskAsCompleted(isCompleted, taskCount);
                    break;

                case "4":
                    ShowTasks(tasks, isCompleted, taskCount);
                    break;

                case "5":
                    Console.WriteLine("Dastur tugatildi.");
                    return;

                default:
                    Console.WriteLine("Noto'g'ri tanlov. Qayta urinib ko'ring.");
                    break;
            }
        }
    }

    static void AddTask(string[] tasks, bool[] isCompleted, ref int taskCount)
    {
        Console.Write("Yangi vazifani kiriting: ");
        string newTask = Console.ReadLine();

        if (taskCount < tasks.Length)
        {
            tasks[taskCount] = newTask;
            isCompleted[taskCount] = false;
            taskCount++;
            Console.WriteLine("Vazifa muvaffaqiyatli qo'shildi.");
        }
        else
        {
            Console.WriteLine("Vazifalar ro'yxati to'lib ketgan.");
        }
    }

    static void DeleteTask(string[] tasks, bool[] isCompleted, ref int taskCount)
    {
        ShowTasks(tasks, isCompleted, taskCount);

        Console.Write("O'chiriladigan vazifaning raqamini kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= taskCount)
        {
            for (int i = index - 1; i < taskCount - 1; i++)
            {
                tasks[i] = tasks[i + 1];
                isCompleted[i] = isCompleted[i + 1];
            }

            taskCount--;
            Console.WriteLine("Vazifa muvaffaqiyatli o'chirildi.");
        }
        else
        {
            Console.WriteLine("Noto'g'ri raqam kiritildi.");
        }
    }

    static void MarkTaskAsCompleted(bool[] isCompleted, int taskCount)
    {
        ShowTasks(tasks: null, isCompleted, taskCount);

        Console.Write("Bajarilgan deb belgilanadigan vazifaning raqamini kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= taskCount)
        {
            isCompleted[index - 1] = true;
            Console.WriteLine("Vazifa bajarilgan deb belgilandi.");
        }
        else
        {
            Console.WriteLine("Noto'g'ri raqam kiritildi.");
        }
    }

    static void ShowTasks(string[] tasks, bool[] isCompleted, int taskCount)
    {
        if (taskCount == 0)
        {
            Console.WriteLine("Vazifalar ro'yxati bo'sh.");
            return;
        }

        Console.WriteLine("\nVazifalar ro'yxati:");
        for (int i = 0; i < taskCount; i++)
        {
            string status = isCompleted[i] ? "(Bajarilgan)" : "(Bajarilmagan)";
            Console.WriteLine($"{i + 1}. {tasks[i]} {status}");
        }
    }
}
