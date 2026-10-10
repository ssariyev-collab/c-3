// //1CI SUAL
// using System;
// using System.Collections.Generic;

// namespace LibrarySystem
// {
//     public class Book
//     {
//         public string Title { get; set; }
//         public string Author { get; set; }
//         public string ISBN { get; set; }

//         private bool isAvailable;

//         public bool IsAvailable => isAvailable;

//         public Book(string title, string author, string isbn)
//         {
//             Title = title;
//             Author = author;
//             ISBN = isbn;
//             isAvailable = true;
//         }

//         public void BorrowBook()
//         {
//             if (isAvailable)
//             {
//                 isAvailable = false;
//                 Console.WriteLine($"'{Title}' kitab alındı.");
//             }
//             else
//             {
//                 Console.WriteLine($"'{Title}' kitab  başqasi terefden alınmış!");
//             }
//         }

//         public void ReturnBook()
//         {
//             if (!isAvailable)
//             {
//                 isAvailable = true;
//                 Console.WriteLine($"'{Title}' kitab iade edildi.");
//             }
//             else
//             {
//                 Console.WriteLine($"'{Title}' kitab kitabxanadadir.");
//             }
//         }

//         public void DisplayInfo()
//         {
//             string status = isAvailable ? "Mevcut" : "Ödünç Alındı";
//             Console.WriteLine($"Kitap: {Title,-22} | Yazar: {Author,-18} | ISBN: {ISBN,-15} | Durum: {status}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Book> library = new List<Book>
//             {
//                 new Book("1984", "George Orwell", "978-0451524935"),
//                 new Book("Sefiller", "Victor Hugo", "978-0140444308"),
//                 new Book("Hamsə", "Nizami Gəncəvi", "978-9952341234"),
//                 new Book("Ali ve Nino", "Kurban Said", "978-0385420174"),
//                 new Book("Kürk Mantolu Madonna", "Sabahattin Ali", "978-9753638029")
//             };

//             Console.WriteLine("=== İlk Kitabxana Listesi ===");
//             foreach (var book in library)
//             {
//                 book.DisplayInfo();
//             }

//             Console.WriteLine("\n=== 2 Kitabın Ödünç Alınması ===");
//             library[0].BorrowBook();
//             library[3].BorrowBook();

//             Console.WriteLine("\n=== Son Kitabxana Vexiyyeti ===");
//             foreach (var book in library)
//             {
//                 book.DisplayInfo();
//             }
//         }
//     }
// }


//2CI SUAL
// using System;
// using System.Collections.Generic;

// namespace ShapeSystem
// {
//     public interface IShape
//     {
//         double CalculateArea();
//         double CalculatePerimeter();
//     }

//     public class Circle : IShape
//     {
//         public double Radius { get; set; }

//         public Circle(double radius)
//         {
//             Radius = radius;
//         }

//         public double CalculateArea()
//         {
//             return Math.PI * Radius * Radius;
//         }

//         public double CalculatePerimeter()
//         {
//             return 2 * Math.PI * Radius;
//         }
//     }

//     public class Rectangle : IShape
//     {
//         public double Width { get; set; }
//         public double Height { get; set; }

//         public Rectangle(double width, double height)
//         {
//             Width = width;
//             Height = height;
//         }

//         public double CalculateArea()
//         {
//             return Width * Height;
//         }

//         public double CalculatePerimeter()
//         {
//             return 2 * (Width + Height);
//         }
//     }

//     public class Triangle : IShape
//     {
//         public double SideA { get; set; }
//         public double SideB { get; set; }
//         public double SideC { get; set; }

//         public Triangle(double sideA, double sideB, double sideC)
//         {
//             SideA = sideA;
//             SideB = sideB;
//             SideC = sideC;
//         }

//         public double CalculatePerimeter()
//         {
//             return SideA + SideB + SideC;
//         }

//         public double CalculateArea()
//         {
//             double s = CalculatePerimeter() / 2;
//             return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
//         }
//     }

//     public static class ShapeHelper
//     {
//         public static double CalculateArea(double radius)
//         {
//             return Math.PI * radius * radius;
//         }

//         public static double CalculateArea(double width, double height)
//         {
//             return width * height;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<IShape> shapes = new List<IShape>
//             {
//                 new Circle(5),
//                 new Rectangle(4, 6),
//                 new Triangle(3, 4, 5)
//             };

//             Console.WriteLine("=== Fiqurların Sahə və Perimetri ===");

//             foreach (IShape shape in shapes)
//             {
//                 string shapeName = shape.GetType().Name;
//                 Console.WriteLine($"Fiqur: {shapeName}");
//                 Console.WriteLine($"  - Sahə    : {shape.CalculateArea():F2}");
//                 Console.WriteLine($"  - Perimetr: {shape.CalculatePerimeter():F2}\n");
//             }

//             Console.WriteLine("=== ShapeHelper Overload Metodlarının Yoxlanılması ===");
//             Console.WriteLine($"Radiusu 3 olan Dairənin Sahəsi: {ShapeHelper.CalculateArea(3):F2}");
//             Console.WriteLine($"4x8 ölçülü Düzbucaqlının Sahəsi: {ShapeHelper.CalculateArea(4, 8):F2}");
//         }
//     }
// }

//3CU SUAL
// using System;
// using System.Collections.Generic;

// namespace VehicleSystem
// {
//     public class Vehicle
//     {
//         public string Brand { get; set; }
//         public int Speed { get; set; }

//         public Vehicle(string brand, int speed)
//         {
//             Brand = brand;
//             Speed = speed;
//         }

//         public virtual void MakeSound()
//         {
//             Console.WriteLine($"{Brand} ümumi nəqliyyat səsi çıxarır.");
//         }
//     }

//     public class Car : Vehicle
//     {
//         public Car(string brand, int speed) : base(brand, speed) { }

//         public override void MakeSound()
//         {
//             Console.WriteLine($"{Brand} (Sürət: {Speed} km/s) -> Bip Bip!");
//         }
//     }

//     public class Motorcycle : Vehicle
//     {
//         public Motorcycle(string brand, int speed) : base(brand, speed) { }

//         public override void MakeSound()
//         {
//             Console.WriteLine($"{Brand} (Sürət: {Speed} km/s) -> Vrrrroooom!");
//         }
//     }

//     public class Bicycle : Vehicle
//     {
//         public Bicycle(string brand, int speed) : base(brand, speed) { }

//         public override void MakeSound()
//         {
//             Console.WriteLine($"{Brand} (Sürət: {Speed} km/s) -> Zıng Zıng!");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Vehicle> vehicles = new List<Vehicle>
//             {
//                 new Car("BMW", 220),
//                 new Motorcycle("Yamaha", 180),
//                 new Bicycle("Giant", 30)
//             };

//             Console.WriteLine("=== Nəqliyyat Vasitələrinin Səsləri ===\n");

//             foreach (Vehicle vehicle in vehicles)
//             {
//                 vehicle.MakeSound();
//             }
//         }
//     }
// }
