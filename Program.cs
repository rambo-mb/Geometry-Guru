Console.WriteLine("Welcome to Geometry Guru!");
Console.WriteLine("1. Doira yuzasini hisoblash");
Console.WriteLine("2. To'g'ri burchakli uchburchak yuzasini hisoblash");
Console.WriteLine("3. To'g'ri to'rtburchak yuzasini hisoblash");
Console.Write("Sizning tanlovingiz: ");

int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tanlov qilinmoqda...");
if (choice == 1)
{
    Console.Write("Doira radiusini kiriting: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine("Hisoblanmoqda...");
    Console.WriteLine($"Doira yuzasi: {Math.Round(area)}");
}
else if (choice == 2)
{
    Console.Write("Uchburchakning birinchi katetini kiriting: ");
    double side = Convert.ToDouble(Console.ReadLine());
    Console.Write("Uchburchakning ikkinchi katetini kiriting: ");
    double height = Convert.ToDouble(Console.ReadLine());
    double area = 0.5 * side * height;
    Console.WriteLine("Hisoblanmoqda...");
    Console.WriteLine($"Uchburchak yuzasi: {area}");
}
else if (choice == 3)
{
    Console.Write("To'g'ri to'rtburchakning bir tomonini kiriting: ");
    double side1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("To'g'ri to'rtburchakning ikkinchi tomonini kiriting: ");
    double side2 = Convert.ToDouble(Console.ReadLine());
    double area = side1 * side2;
    Console.WriteLine("Hisoblanmoqda...");
    Console.WriteLine($"To'g'ri to'rtburchak yuzasi: {area}");
}
else
{
    Console.WriteLine("Noto'g'ri tanlov!");
}

Console.WriteLine("Dastur tugadi!");