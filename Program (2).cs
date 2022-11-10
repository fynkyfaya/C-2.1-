Console.Write("X value: ");
var x = double.Parse(Console.ReadLine());

Console.Write("Y value: ");
var y = double.Parse(Console.ReadLine());


if (y >= x && y >= -x && y <= 1) {
    Console.WriteLine("Точка входит в область");
} else {
    Console.WriteLine("Точка не входит в область");
}