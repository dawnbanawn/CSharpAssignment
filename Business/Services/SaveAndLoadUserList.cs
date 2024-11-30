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
    internal class SaveAndLoadUserList
    {
        readonly string filePath = "/";
        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        public string SaveJson(List<UserModel> list) {

            var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
            File.WriteAllText(filePath, json);
            return "list saved!";
        }

        public List<UserModel> LoadJson()
        {

            var json = File.ReadAllText(filePath);
            var list = JsonSerializer.Deserialize<List<UserModel>>(json, _jsonSerializerOptions);
            return list ?? [];
        }
    }

}
