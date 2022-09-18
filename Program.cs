System.Console.WriteLine("Hello, World! Version 0.0.1");

string filename = "/home/user/Projects/CSVReader/employee.csv";


using (StreamReader reader = new StreamReader(filename))
{
    string? line;

    while ((line = reader.ReadLine()) != null)
    {
        System.Console.WriteLine(line);
    }
}