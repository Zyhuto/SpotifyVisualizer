// See https://aka.ms/new-console-template for more information
using SpotifyVisualizer;
using Microsoft.Win32;
Class1 program = new Class1();

while (true)
{
    Console.WriteLine("Please Enter A Filepath");
    string path = Console.ReadLine().Trim('"');
    program.AddData(path);
    Console.WriteLine(program.Info());

}


    

Console.ReadKey();


