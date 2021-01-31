using System;

namespace ConsoleApplication
{    //ДЗ №1.
     //Задание 2.

        class Rectangle
        {
            public double side1 ;
            public double side2 ;

            public Rectangle(double s1, double s2)
            {
                side1 = s1;
                side2 = s2;
            }


        public double Side1 {
            get
            {
                return AreaCalculator();
            }
         }
        public double AreaCalculator()
        {
            double Area = side1 * side2; 
            return Area;
        }

        public double Side2 {
            get
            {
                return PerimeterCalculator();
            }
         }
        public double PerimeterCalculator()
        {
            double Perimetr = (side1 + side2)*2;
            return Perimetr;
        }
    }




    //Задание 3.
    class Book
    {
        Title title;
        Author author;
        Content content; 
        public Book(string t, string a, string c)
        {
            title = new Title(t);
            author = new Author(a);
            content = new Content(c);
        }
        public void ShowAll()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    class Title
    {
        string title;
        public Title(string t)
        {
            title = t;
        }
        public void Show()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Названия книги: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
        }
    }

    class Author
    {
        string author;
        public Author(string a)
        {
            author = a;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Автор книги: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(author);
        }
    }

    class Content
    {
        string content;
        public Content(string c)
        {
            content = c;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Содержания книги: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
    }


    //Задание 4.

    class Calculator
    {
        public double number;
        public double percent;

        public Calculator(double num, double perc)
        {
            number = num;
            percent = perc;
        }

        public double Rsult
        {
            get
            {
                return Result();
            }
        }
        public double Result()
        {
            double result = number * percent / 100;
            return result;
        }
    }



    //ДЗ №2.
    //Задание 2.

    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Converter()
        {
            usd = 11.3950; // 1 доллар = 11,3950, 1 сомони = 0,0878 доллар
            this.usd = usd;
            eur = 13.780; // 1 евро = 13,7800 сомони, 1 сомони = 0,0726 евро 
            this.eur = eur;
            rub = 0.15; // 1 рубль = 0,1496 сомони, 1 TJS = 6.6859 RUB
            this.rub = rub;
        }

        public double ConvertTJSUSD(double TJS)
        {
            return TJS / this.usd;
        }
        public double ConvertTJSEUR(double TJS)
        {
            return TJS / this.eur;
        }
        public double ConvertTJSRUB(double TJS)
        {
            return TJS / this.rub;
        }
        public double ConvertUSDTJS(double USD)
        {
            return USD * this.usd;
        }
        public double ConvertEURTJS(double EUR)
        {
            return EUR * this.eur;
        }
        public double ConvertRUBTJS(double RUB)
        {
            return RUB * this.rub;
        }
    }


    //Задание 3.

    class Employee
    {
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string POSITION { get; set; }
        public int EXPERIENCE { get; set; }




        public Employee(string name, string surname, string position, int experinece)
        {
            this.NAME = name;
            this.SURNAME = surname;
            this.POSITION = position;
            this.EXPERIENCE = experinece;
        }

        public double zarplata;
        public double percent2;



        public void GetInfo()
        {
            Console.WriteLine($"Имя: {NAME}");
            Console.WriteLine($"Фамилия: {SURNAME}");
            Console.WriteLine($"Должность: {POSITION}");
            Console.WriteLine($"Опыт работы: {EXPERIENCE}");
        }
        public void esliposition()
        {
            if (POSITION == "Доктор")
            {

                if (EXPERIENCE <= 3)
                {
                    percent2 = 2400 - (2400 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (EXPERIENCE >= 4)
                {
                    percent2 = 3400 - (3400 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (POSITION == "Преподаватель")
            {

                if (EXPERIENCE <= 3)
                {
                    percent2 = 1400 - (1400 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (EXPERIENCE >= 4)
                {
                    percent2 = 2000 - (2000 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (POSITION == "Программист")
            {
                if (EXPERIENCE <= 1)
                {
                    percent2 = 2200 - (2200 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (EXPERIENCE >= 2)
                {
                    percent2 = 3400 - (3400 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if (POSITION == "Директор")
            {
                if (EXPERIENCE <= 1)
                {
                    percent2 = 3000 - (3000 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (EXPERIENCE >= 2)
                {
                    percent2 = 4000 - (4000 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            if (POSITION == "Слесарь")
            {
                if (EXPERIENCE <= 1)
                {
                    percent2 = 1000 - (1000 * 13 / 100);
                    zarplata = percent2 - (percent2 * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (EXPERIENCE >= 2)
                {
                    percent2 = 1500 - (1500 * 13 / 100);
                    zarplata = zarplata - (zarplata * 1 / 100);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ваша заработная плата c учетом налогов и пенсионного фонда =  {zarplata} сомон");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //ДЗ №1.
            //Задание 2.

            Console.Write("Введите высоту прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle (side1, side2);
            Console.WriteLine();
            Console.Write("Площадь прямоугольника = ");
            Console.WriteLine(rectangle.AreaCalculator());
            Console.Write("Периметр прямоугольника = ");
            Console.WriteLine(rectangle.PerimeterCalculator());

            //Задание 3.

            Console.Write("Введите названия книги: ");
            string title = Console.ReadLine();
            Console.Write("Введите имя автора книги: ");
            string author = Console.ReadLine();
            Console.Write("Введите содержания книги: ");
            string content = Console.ReadLine();
            Book book1 = new Book (title,author,content);

            book1.ShowAll();

            //Задание 4.

            Console.Write("Введите число: ");
            var numbe = double.TryParse(Console.ReadLine(), out var number);
            if (!numbe)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;

            }
             if (number <1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Ваша число не может быть меньше нуля или отрецательным");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Введите процент числа который хотите знать: ");
            var percen = double.TryParse(Console.ReadLine(), out var percent);
            if (!percen)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Вы ввели не число");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;

            }
            if ((percent < 0 || percent > 101) )
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("Процент не может быть меньше 1% и больше 100%");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Calculator calculator = new Calculator(number, percent);
            Console.Write($"{percent}-% от вашего числа = ");
            Console.WriteLine(calculator.Result());


            //ДЗ №2.
            //Задание 2.

            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Выбирите свою волюту: 1.USD, 2.EUR, 3.RUB, 4.TJS.");
            System.Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Пример выбора волюты: 1");
            System.Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите тип вашей валюты: ");

            var vibor = int.TryParse(Console.ReadLine(), out var vbor);
            if (!vibor)
            {
                Console.WriteLine();
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не число!");
                return;
            }
            if (vbor < 1 || vbor > 4)
            {
                Console.WriteLine();
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Такого тип валюты не существует!");
                return;

            }
            else
            {

                if (vbor == 1)
                {
                    Console.WriteLine();
                    Console.Write("Введите вашу сумму: ");
                    var amount = double.TryParse(Console.ReadLine(), out var Amount);
                    if (!amount)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не число!");
                        return;
                    }
                    if (Amount < 1)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                        return;
                    }
                    Console.WriteLine();
                    Converter USDtoTJS = new Converter();
                    double value = USDtoTJS.ConvertUSDTJS(Amount);
                    System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Ваша сумма {Amount}-USD равняется {value}-TJS ");
                    return;
                }
                if (vbor == 2)
                {
                    Console.WriteLine();
                    Console.Write("Введите вашу сумму: ");
                    var amount = double.TryParse(Console.ReadLine(), out var Amount);
                    if (!amount)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не число!");
                        return;
                    }
                    if (Amount < 1)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                        return;
                    }
                    Console.WriteLine();
                    Converter EURtoTJS = new Converter();
                    double value = EURtoTJS.ConvertEURTJS(Amount);
                    System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Ваша сумма {Amount}-EUR равняется {value}-TJS ");
                    return;
                }
                if (vbor == 3)
                {
                    Console.WriteLine();
                    Console.Write("Введите вашу сумму: ");
                    var amount = double.TryParse(Console.ReadLine(), out var Amount);
                    if (!amount)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не число!");
                        return;
                    }
                    if (Amount < 1)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                        return;
                    }
                    Console.WriteLine();
                    Converter RUBtoTJS = new Converter();
                    double value = RUBtoTJS.ConvertRUBTJS(Amount);
                    System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Ваша сумма {Amount}-RUB равняется {value}-TJS ");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Выбирите на кокую волюту вы хотите конвертировать: 1.USD, 2.EUR, 3.RUB.");
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Пример выбора волюты: 1");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите тип вашей валюты: ");
                    var vibor2 = int.TryParse(Console.ReadLine(), out var vbor2);

                    if (!vibor2)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы ввели не число!");
                        return;
                    }
                    if (vbor2 < 1 || vbor2 > 3)
                    {
                        Console.WriteLine();
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Такого тип валюты не существует!");
                        return;

                    }
                    if (vbor2 == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Введите вашу сумму: ");
                        var amount = double.TryParse(Console.ReadLine(), out var Amount);
                        if (!amount)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не число!");
                            return;
                        }
                        if (Amount < 1)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                            return;
                        }
                        Console.WriteLine();
                        Converter TJStoUSD = new Converter();
                        double value = TJStoUSD.ConvertTJSUSD(Amount);
                        System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Ваша сумма {Amount}-TJS равняется {value}-USD ");
                        return;
                    }
                    if (vbor2 == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Введите вашу сумму: ");
                        var amount = double.TryParse(Console.ReadLine(), out var Amount);
                        if (!amount)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не число!");
                            return;
                        }
                        if (Amount < 1)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                            return;
                        }
                        Console.WriteLine();
                        Converter TJStoEUR = new Converter();
                        double value = TJStoEUR.ConvertTJSEUR(Amount);
                        System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Ваша сумма {Amount}-TJS равняется {value}-EUR ");
                        return;
                    }
                    if (vbor2 == 3)
                    {
                        Console.WriteLine();
                        Console.Write("Введите вашу сумму: ");
                        var amount = double.TryParse(Console.ReadLine(), out var Amount);
                        if (!amount)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не число!");
                            return;
                        }
                        if (Amount < 1)
                        {
                            Console.WriteLine();
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ваша сумма не может быть отрецательным или нулём!");
                            return;
                        }
                        Console.WriteLine();
                        Converter TJStoRUB = new Converter();
                        double value = TJStoRUB.ConvertTJSRUB(Amount);
                        System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Ваша сумма {Amount}-TJS равняется {value}-RUB ");
                        return;
                    }


                }
            }


            //Задание 3.

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Введите ответы только русскими буквами (1 - буква должна быть с большой)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите своё Имя = ");
            string NAME = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите свою Фамилию = ");
            string SURNAME = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Список вакансий которые у нас есть \n1 - Доктор \n2 - Преподаватель \n3 - Программист \n4 - Директор \n5 - Слесарь \nВведите название вакансии которые есть в списке!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите должность на которую вы претендуйте = ");
            string POSITION = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите свой стаж работы  = ");
            int EXPERIENCE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Employee employee = new Employee(NAME, SURNAME, POSITION, EXPERIENCE);
            employee.GetInfo();
            employee.esliposition();

        }
    }
}
