namespace cSharp_Fundamentals
{
    internal class Program
    {
        static string CheckImageOrientation(int w, int h)
        {
            if (w > h)
            {
                return "Landscape";
            }
            else if (w < h)
            {
                return "Potrait";
            }
            else
            {
                return "Square";
            }
        }

        static void FaceBookPostsLikesCheck()
        {
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                string inputName = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(inputName))
                {
                    break;
                }
                else
                {
                    names.Add(inputName);
                }
            }

            if (names.Count > 0)
            {
                var likes = string.Join(", ", names);
                Console.WriteLine("These person likes the post: " + likes);
            }
        }

        static void ReverseSorting()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                string inputName = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(inputName))
                {
                    break;
                }
                else
                {
                    names.Add(inputName);
                }
            }

            if (names.Count > 0)
            {
                names.Reverse();

                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void UniqueNumbers()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter unique number: ");
                string inputNumber = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(inputNumber))
                {
                    break;
                }

                if (int.TryParse(inputNumber, out int number))
                {
                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("The number is not unique. Please enter a unique number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            numbers.Sort();
            var nums = string.Join(", ", numbers);
            Console.WriteLine(nums);
        }

        static void DuplicateUniqueNumbers()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter number: ");
                string inputNumber = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(inputNumber) || inputNumber.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (int.TryParse(inputNumber, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Enter valid integer number.");
                }
            }

            if (numbers.Count > 0)
            {
                var uniqueNumbers = numbers.Distinct().ToList();
                uniqueNumbers.Sort();

                foreach (var item in uniqueNumbers)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void DateTimeFormat()
        {
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToShortTimeString());

            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday.ToShortDateString());
            Console.WriteLine(yesterday.ToString("U"));
        }

        static void ConsectiveNumbersMain()
        {
            Console.Write("Enter few numbers with hypen: ");
            string numbers = Console.ReadLine() ?? "";

            if (ConsectiveNumbers(numbers))
            {
                Console.WriteLine("Consective Numbers");
            }
            else
            {
                Console.WriteLine("Not Consective Numbers");
            }
        }

        static bool ConsectiveNumbers(string numbers)
        {
            string[] parts = numbers.Split('-');

            if (parts.Length <= 1)
            {
                return false;
            }

            for (int i = 1; i < parts.Length; i++)
            {
                if (int.Parse(parts[i]) != int.Parse(parts[i - 1]) + 1)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            // Excersise 1
            //Console.Write("Enter number: ");
            //string number = Console.ReadLine() ?? "";

            //if(Convert.ToInt32(number) > 0 && Convert.ToInt32(number) <= 10 )
            //{
            //    Console.WriteLine("Valid Number");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number");
            //}


            // Excersise 2
            //Console.Write("Enter first number: ");
            //string number1 = Console.ReadLine() ?? "";
            //Console.Write("Enter second number: ");
            //string number2 = Console.ReadLine() ?? "";

            //int maxNum = Math.Max(Convert.ToInt32(number1), Convert.ToInt32(number2));
            //Console.WriteLine($"Max number: {maxNum}");


            // Excersise 3
            //Console.Write("Enter image width: ");
            //string width = Console.ReadLine() ?? "";
            //Console.Write("Enter image height: ");
            //string height = Console.ReadLine() ?? "";

            //string orientation = CheckImageOrientation(Convert.ToInt32(width), Convert.ToInt32(height));
            //Console.WriteLine("Image orientation: " + orientation);


            // Generate random password using Random Class
            //var random = new Random();
            //var buffer = new char[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    buffer[i] = (char) ('a' + random.Next(0, 26));
            //}

            //var password = new String(buffer);
            //Console.WriteLine(password);


            //var player = new Player();
            //player.firstName = "John";
            //player.lastName = "Smith";

            //player.FullName();


            //var numbers = new int[3] { 1, 2, 3 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //FaceBookPostsLikesCheck();

            //ReverseSorting();

            //UniqueNumbers();
            //DuplicateUniqueNumbers();

            //DateTimeFormat();

            //ConsectiveNumbersMain();




            //=== Inetface Example ===
            //var dbMigrator = new DBMigrator();
            //dbMigrator.RegisterLog(new ConsoleLogger());
            //dbMigrator.RegisterLog(new FileLogger(@"C:\mdm\log.txt"));
            //dbMigrator.Migrate();


            //=== Generics Example + Dynamic variable ===
            var sum = Generics.Add<int>(25, 10);
            Console.WriteLine("SUM: " + sum);

            var compare = Generics.CompareItems<int>(10, 10);
            if(compare)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            //var num = Generics.DynamicType<int>(12);
            //Console.WriteLine("Number Type: " + num);
            var name = Generics.DynamicType<string>("rizwan");
            Console.WriteLine("Name Type: " + name);
        }
    }
}