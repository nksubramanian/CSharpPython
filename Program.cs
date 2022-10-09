// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
ProcessPython();



static void ProcessPython()
{
    var psi = new ProcessStartInfo();
    psi.FileName = @"C:\Users\Subramanian.N\AppData\Local\Programs\Python\Python310\python.exe";
    var script = @"D:\RunningPythonFromCSharp\DaysBetweenDates.py";
    var start = "2019-1-1";
    var end = "2019-1-22";

    psi.Arguments = $"\"{script}\" \"{start}\" \"{end}\"";
    psi.UseShellExecute = false;
    psi.CreateNoWindow = true;
    psi.RedirectStandardOutput = true;
    psi.RedirectStandardError = true;

    var errors = "";
    var results = "";

    using (var process = Process.Start(psi))
    {
        errors = process.StandardError.ReadToEnd();
        results = process.StandardOutput.ReadToEnd();
    }

    Console.WriteLine("ERRORS:");
    Console.WriteLine(errors);
    Console.WriteLine();
    Console.WriteLine("Results");
    Console.WriteLine(results);

}
