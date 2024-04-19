
        int[] numbers = { 1, 2, 3, 4, 5 ,6, 7};
        var evenNumbers = numbers.Where(num => num % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        List<int> grades = new List<int> { 85, 90, 78, 95, 88 , 80, 50};


        double averageGrade = grades.Average();

        Console.WriteLine($"Average grade: {averageGrade}");
        Console.WriteLine();
    

        Greet("Fatma");
        Console.WriteLine();

        double volume1 = CalculateVolume(5, 3, 2);
        double volume2 = CalculateArea(4, 2);
        Console.WriteLine($"Volume of the box: {volume1}");
        Console.WriteLine($"Volume of area:{ volume2}");

    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    static double CalculateVolume(double length, double width, double height)
    {
        return length * width * height;
    }

    static double CalculateArea(double width, double height)
    {
    return  width * height;
    }



