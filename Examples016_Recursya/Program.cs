// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerRecMath(2, 11));

// int n = 1;
// void FindWord(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new string(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWord(alphabet, word, length + 1);
//     }
// }

// FindWord("ausv", new char[1]);

// string path = "D:/TEMP/Examples/examples001";
// DirectoryInfo dir = new DirectoryInfo(path);
// Console.WriteLine(dir.CreationTime);
// FileInfo[] file = dir.GetFiles();
// for (int i = 0; i < file.Length; i++)
// {
//     Console.WriteLine(file[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent} {catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent} {files[i].Name}");
//     }
// }

// path = "D:/TEMP/Examples/examples001";
// CatalogInfo(path);


// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

// string emp = string.Empty;

// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");

// }

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}