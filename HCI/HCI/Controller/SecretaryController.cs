using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using HCI.Service;
using Service;

namespace HCI.Controller
{
    public class SecretaryController
    {
        private readonly SecretaryService _service;

        public SecretaryController(SecretaryService service)
        {
            _service = service;
        }


        public Secretary GetSecretary(uint id)
        {
            return _service.GetSecretary(id);
        }


        public IEnumerable<Secretary> GetAll()
        {
            return _service.GetAll();
        }

        public Secretary FindSecretaryByUsername(string username)
        {
            return _service.FindSecretaryByUsername(username);
        }

    }
}
