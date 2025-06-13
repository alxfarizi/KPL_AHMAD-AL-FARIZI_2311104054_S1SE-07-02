using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class FileHandler
{
    public static List<UserHandler.User> LoadUsers(string filePath)
    {
        string json = File.ReadAllText(filePath);
        var data = JsonConvert.DeserializeObject<DataContainer>(json);
        return data?.Users ?? new List<UserHandler.User>();
    }

    public static void SaveUsers(string filePath, List<UserHandler.User> users)
    {
        var data = new DataContainer { Users = users };
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    private class DataContainer
    {
        public List<UserHandler.User> Users { get; set; }
    }
}
