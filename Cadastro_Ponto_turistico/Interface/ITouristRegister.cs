using Cadastro_Ponto_turistico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Ponto_turistico.Interface
{
    public interface ITouristRegister
    {
        HttpResponseMessage Create(User user);
    }
}
