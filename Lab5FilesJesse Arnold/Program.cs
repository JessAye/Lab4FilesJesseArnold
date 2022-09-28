using System.Reflection;
using Lab5FilesJesse_Arnold;
using Microsoft.VisualBasic;

class Program
{
    public static void Main()
    {
        var localFilePath =
            System.IO.Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), "data.csv");
        string filePath = new Uri(localFilePath).LocalPath;
        StreamReader originalFile = null;
        Console.WriteLine(filePath);
        if (File.Exists(filePath))
        {
            originalFile = new StreamReader(File.OpenRead(filePath));
            List<Person> listA = new List<Person>();
            while (!originalFile.EndOfStream)
            {
                var line = originalFile.ReadLine();
                var values = line.Split(',');
                for (int i = 0; i < values.Length - 1;)
                {
                    Person person = new Person(values[i], values[i + 1],
                        new Address(values[i + 2], values[i + 3], values[i + 4], values[i + 5]));
                    listA.Add(person);
                    i = i + 6;
                }


                {
                }
                foreach (var person in listA)
                {
                    Console.WriteLine(person.ToString());
                }
            }

            Console.WriteLine("Enter File Name(without extension)");
            string? fileName = Console.ReadLine();
            fileName = $"{fileName}{".psv"}";
            var newlocalfilePath =
                System.IO.Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), fileName);
            string newFilePath = new Uri(newlocalfilePath).LocalPath;
            using (StreamWriter writer = File.CreateText($"{newFilePath}"))
            {
                foreach (var person in listA)
                {
                    writer.WriteLine(person.ToString());
                }
            }
        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }
    }
}
