// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Console.WriteLine($"Before {pallets[0].ToLower()} and {pallets[1].ToLower()}");
// Array.Clear(pallets, 0, 2);

// if (pallets[0] != null)
//     Console.WriteLine($"After---{pallets[0].ToLower()}---and---{pallets[1].ToLower()}");

// // Console.WriteLine();
// // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// // foreach (var pallet in pallets)
// // {
// //     Console.WriteLine($"-- {pallet}");
// // }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }


// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// // Console.WriteLine(valueArray);
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join("$", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


string pangram = "The quick brown fox jumps over the lazy dog";

// 1. store all the words of the sentence in an array
string[] words = pangram.Split(' ');

// 2. store each word in a char array 
for (int i = 0; i < words.Length; i++)
{
    string word = words[i];
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    string reversedWord = new string(wordArray);
    Console.Write($"{reversedWord} ");
}
// 3. reverse the word in the char array 

// 4. repeat this for all the words in the sentence.
