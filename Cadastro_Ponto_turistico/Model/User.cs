using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Ponto_turistico.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Responsible { get; set; }
        public string EmailResponsible { get; set; }
        public string PhoneResponsible { get; set; }
    }
}
