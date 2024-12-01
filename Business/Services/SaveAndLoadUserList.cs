using Business.Data;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SaveAndLoadUserList 
    {
        readonly string _directoryPath = @"c:\Data";
        readonly string _fileName = "list.json";
        string filePath;
        public SaveAndLoadUserList()
        {
            filePath = Path.Combine(_directoryPath, _fileName);
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        UserData userData = new UserData();

        public string SaveJson() {          

 


            var json = JsonSerializer.Serialize(userData.GetList(), _jsonSerializerOptions);
            File.WriteAllText(filePath, json);
            return "fff";
        }

        public string LoadJson()
        {
            try {
                string filePath = Path.Combine(_directoryPath, _fileName);

                var json = File.ReadAllText(filePath);

                if (json != null)
                {
                    Console.WriteLine("List loadeeed:");
                    var list = JsonSerializer.Deserialize<List<UserModel>>(json, _jsonSerializerOptions);
                    return userData.LoadList(list);

                }
                else
                {
                    Console.WriteLine("list nooot loaded!:");

                    return "It didnt go";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No list found");
                return "It didnt go";

            }

        }
    }

}
