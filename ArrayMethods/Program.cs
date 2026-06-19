string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Console.WriteLine($"Before {pallets[0]} and {pallets[1]}");
Array.Clear(pallets, 2, 2);
Console.WriteLine($"After---{pallets[0]}---and---{pallets[1]}");

Console.WriteLine();
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
