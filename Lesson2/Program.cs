try
{
    Console.WriteLine("Введите R");
    double R = double.Parse(Console.ReadLine());
    double L = 2 * Double.Pi * R;
    Console.WriteLine($"L={L:F2}");
    double S = Double.Pi * R * R;
    Console.WriteLine($"S={S:F2}");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}