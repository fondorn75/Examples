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


void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();