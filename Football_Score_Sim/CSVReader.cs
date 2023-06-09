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
                    Console.WriteLine("The match {0} - {1} was canceled", values[0], values[1]);
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
    
    public static void ReadLeagueFile(string filePath, Action<string, int, int, int, int, int> func)
    {
        using(var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                func(values[0], Convert.ToByte(values[1]), Convert.ToByte(values[2]), Convert.ToByte(values[3]), Convert.ToByte(values[4]), Convert.ToByte(values[5]));
            }
        }
    }
    
    public static void ReadDirectoryRounds(string dirPath, Action<string, string, int, int> processFunc, Action displayFunc)
    {
        DirectoryInfo dir = new DirectoryInfo(dirPath);

        int index = 0;
        foreach (FileInfo fInfo in dir.GetFiles())
        {
            
            string filePath = dirPath + "/" + fInfo.Name;
            ReadFile(filePath, processFunc);
            Console.WriteLine("\n Round no. " + (++index) + ": \n");
            displayFunc();
        }
    }
}