using System;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so can doc: ");
        uint number = uint.Parse(Console.ReadLine());

        if (number < 10)
        {
           switch (number)
            {
                case 0: 
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
            }
        }
        else if (number < 20)
        {
            int chuc = (int)number / 10;
            int dv = (int)number % 10;
            Console.Write("Muoi ");
            Write_Read(dv);
        }
        else if (number < 99)
        {
            int chuc = (int)number / 10;
            int dv = (int)number % 10;
            switch (chuc)
            {
                case 2:
                    Console.Write("Hai");
                    break;
                case 3:
                    Console.Write("Ba");
                    break;
                case 4:
                    Console.Write("Bon");
                    break;
                case 5:
                    Console.Write("Nam");
                    break;
                case 6:
                    Console.Write("Sau");
                    break;
                case 7:
                    Console.Write("Bay");
                    break;
                case 8:
                    Console.Write("Tam");
                    break;
                case 9:
                    Console.Write("Chin");
                    break;
            }
            Console.Write(" muoi ");
            Write_Read(dv);
        }
        else if (number < 1000)
        {
            int tram = (int)number / 100;
            int chuc = (int)(number % 100) / 10;
            int dv = (int)(number % 100) % 10;
            switch (tram)
            {
                case 1:
                    Console.Write("Mot");
                    break;
                case 2:
                    Console.Write("Hai");
                    break;
                case 3:
                    Console.Write("Ba");
                    break;
                case 4:
                    Console.Write("Bon");
                    break;
                case 5:
                    Console.Write("Nam");
                    break;
                case 6:
                    Console.Write("Sau");
                    break;
                case 7:
                    Console.Write("Bay");
                    break;
                case 8:
                    Console.Write("Tam");
                    break;
                case 9:
                    Console.Write("Chin");
                    break;
            }
            Console.Write(" tram ");
            switch (chuc)
            {
                case 0:
                    Console.Write("le ");
                    break;
                case 1:
                    Console.Write("muoi ");
                    break;
                case 2:
                    Console.Write("hai muoi ");
                    break;
                case 3:
                    Console.Write("ba muoi ");
                    break;
                case 4:
                    Console.Write("bon muoi ");
                    break;
                case 5:
                    Console.Write("nam muoi ");
                    break;
                case 6:
                    Console.Write("sau muoi ");
                    break;
                case 7:
                    Console.Write("bay muoi ");
                    break;
                case 8:
                    Console.Write("tam muoi ");
                    break;
                case 9:
                    Console.Write("chin muoi ");
                    break;
            }
            Write_Read(dv);
        }

    }

    private static void Write_Read(int temp)
    {
        switch (temp)
        {
            case 1:
                Console.WriteLine("mot");
                break;
            case 2:
                Console.WriteLine("hai");
                break;
            case 3:
                Console.WriteLine("ba");
                break;
            case 4:
                Console.WriteLine("bon");
                break;
            case 5:
                Console.WriteLine("nam");
                break;
            case 6:
                Console.WriteLine("sau");
                break;
            case 7:
                Console.WriteLine("bay");
                break;
            case 8:
                Console.WriteLine("tam");
                break;
            case 9:
                Console.WriteLine("chin");
                break;
        }
    }
}