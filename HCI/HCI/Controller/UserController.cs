using Model;
using HCI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI.Controller
{
    public class UserController
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }


        public User GetUser(uint id)
        {
            return _service.GetUser(id);
        }


        public IEnumerable<User> GetAll()
        {
            return _service.GetAll();
        }

        public User FindUserByUsername(string username)
        {
            return _service.FindUserByUsername(username);
        }
    }
}
