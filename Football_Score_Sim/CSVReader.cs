namespace Football_Score_Sim;

public abstract class CSVReader
{
    public static void ReadFile(string filePath, Action<string, string, int, int> func)
    {
        using(var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (values.Length == 4)
                {
                    func(values[0], values[1], Convert.ToByte(values[2]), Convert.ToByte(values[3]));
                } 
                else if (values[2] == "X")
                {
                    Console.WriteLine("The match " + values[0] + " - " + values[1] + " was canceled");
                }
                else
                {
                    Console.WriteLine("There's incorrect formatting in [" + filePath + "] for a round file");
                }

            }
        }
    }
    
    public static void ReadFile(string filePath, Action<string, string> func)
    {
        using(var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                func(values[0], values[1]);
            }
        }
    }
    
    public static void ReadDirectoryFiles(string dirPath, Action<string, string, int, int> func)
    {
        DirectoryInfo dir = new DirectoryInfo(dirPath);

        foreach (FileInfo fInfo in dir.GetFiles())
        {
            
            string filePath = dirPath + "/" + fInfo.Name;
            ReadFile(filePath, func);
            
        }
    }
}