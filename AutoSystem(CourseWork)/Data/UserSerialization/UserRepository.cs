using AutoSystem_CourseWork_.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem_CourseWork_.Data.UserSerialization
{
    public class UserRepository : IBaseRepository<User>
    {
        private List<User> _users = new();
        private string path = string.Empty;

        public List<User> GetUsers() => _users;
        public UserRepository(string path) 
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Путь сохранения не задан или задан неверно!");
        }

        public bool Add(User user)
        {
            if (user == null || _users.Contains(user)) return false;
            var CheckSimilary = from selectUser in _users
                                where (user.Id == selectUser.Id || user.Login == selectUser.Login)
                                select user;
            if (CheckSimilary.Count() != 0) return false;
            _users.Add(user);
            return true;
        }

        public bool Delete(User user)
        {
            if (user == null) return false;
            if (_users.Contains(user))
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }

        public bool Update(User user)
        {
            for (int i=0 ; i <_users.Count; i++)
            {
                if ((_users[i].Id == user.Id) && (_users[i].Login == user.Login))
                {
                    _users[i] = user;
                    return true;
                }
            }
            return false;
        }

        public bool Save()
        {
            if (_users == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            string saveJson = JsonConvert.SerializeObject(_users, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            writer.Write(saveJson);
            return true;
        }

        public bool Load()
        {
            using var stream = File.Open(path, FileMode.Open);
            using var reader = new StreamReader(stream);
            string parseJson = reader.ReadToEnd();
            if (parseJson == null) return false;
            _users = JsonConvert.DeserializeObject<List<User>>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await Task.Run(Save);
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
