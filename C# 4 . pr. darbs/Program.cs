//// 1. 1. Uzdevums

//Console.WriteLine("Ievadiet skaitli");
//int num = Convert.ToInt32(Console.ReadLine());
//int result = 1;

//for (int i = 1; i <= num; i++)
//{
//    Console.WriteLine($"{result} * {i} = {result * i}");
//    result *= i;
//}

//// 1. 2. Uzdevums

//Console.Write("Ievadiet noguldījuma summu: ");
//double deposit = Convert.ToDouble(Console.ReadLine());

//Console.Write("Ievadiet noguldījuma ilgumu (gadu skaitu): ");
//int time = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ievadiet gada % likmi: ");
//double percentage = Convert.ToDouble(Console.ReadLine());

//for (int i = 1;i <= time; i++)
//{
//    double earned = deposit * percentage + deposit;
//    Console.WriteLine($"Summa pēc {i} gada ir {earned:0.00}");
//    deposit = earned;
//}

//// 1. 3. Uzdevums

//Console.WriteLine("y/x |\t1\t2\t3\t4\t5\t6\t7\t8\t9");
//Console.WriteLine("----------------------------------------------------------------------------");

//for (int i = 1; i < 10; i++)
//{
//    Console.WriteLine($"{i}   |\t{1*i}\t{2 * i}\t{3 * i}\t{4 * i}\t{5 * i}\t{6 * i}\t{7 * i}\t{8 * i}\t{9 * i}");
//}





//// 2. 1. Uzdevums

//string input = "";

//do
//{
//    Console.WriteLine("Ievadiet skaitli no 1 līdz 5 vai IZIET lai beigtu darbību");
//    input = Console.ReadLine();

//    switch (input)
//    {
//        case "1":
//            Console.WriteLine("Viens");
//            break;
//        case "2":
//            Console.WriteLine("Divi");
//            break;
//        case "3":
//            Console.WriteLine("Trīs");
//            break;
//        case "4":
//            Console.WriteLine("Četri");
//            break;
//        case "5":
//            Console.WriteLine("Pieci");
//            break;
//        case "IZIET":
//            break;
//        default:
//            Console.WriteLine("Skaitlis nav robežās no 1 līdz 5");
//            break;
//    }
//} while (input != "IZIET");

//Console.WriteLine("PROGRAMMA BEIDZ DARBĪBU");


//// 2. 2. Uzdevums

//Console.Write("Cik reizes pārbaudīt skaitļus? ");
//int cycles = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < cycles; i++)
//{
//    Console.Write("Ievadiet skaitli: ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num % 3 == 0)
//    {
//        Console.WriteLine("Skaitlis dalās ar 3 bez atlikuma!");
//    }
//    else
//    {
//        Console.WriteLine("Skaitlis NEdalās ar 3 bez atlikuma!");
//    }
//}


//// 2. 3. Uzdevums

//Console.WriteLine("Ievadiet trīsstūra platumu");
//int size = Convert.ToInt32(Console.ReadLine());

//for (int i = size; i > 0; i -= 2)
//{
//    int spacing = (size - i) / 2;
//    Console.Write(new string(' ', spacing));
//    Console.WriteLine(new string('*', i));
//}