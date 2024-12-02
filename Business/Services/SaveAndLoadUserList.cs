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
        // Variables for json storing directory.
        readonly string _directoryPath = @"c:\Data";
        readonly string _fileName = "list.json";
        string filePath;
        // Instantiation with options to be able to turn list into json, and vice versa.
        private readonly JsonSerializerOptions _jsonSerializerOptions = new() { WriteIndented = true };
        UserData userData = new();

        // Constructor that ccreates the directory path if not found, and it combines the whole file path.
        public SaveAndLoadUserList()
        {
            filePath = Path.Combine(_directoryPath, _fileName);
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        // Method to save list to json
        public string SaveJson() {
            try
            {
                // Gets the list from the class, and stores it as a json in the variable.
                var json = JsonSerializer.Serialize(userData.GetList(), _jsonSerializerOptions);
                // The json is saved on the disk by using the filepath.
                File.WriteAllText(filePath, json);
                return "Saving the data was successfull.";
            }
            catch (Exception)
            {
                throw new Exception("Saving json didnt work.");
            }

        }
        // Method to load json file.
        public string LoadJson()
        {
            try {
                // A variable stores the json from the disk.
                var json = File.ReadAllText(filePath);

                    Console.WriteLine("List loaded.");
                    // A list is created and stored in a variable.
                    var list = JsonSerializer.Deserialize<List<UserModel>>(json, _jsonSerializerOptions);
                    // The list is sent to a loading method.
                    return userData.LoadList(list);

            }
            catch (Exception)
            {
                throw new Exception("Loading json didnt work.");


            }

        }
    }

}
