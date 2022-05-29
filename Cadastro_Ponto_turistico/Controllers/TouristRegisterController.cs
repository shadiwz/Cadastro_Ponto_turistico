using Cadastro_Ponto_turistico.Interface;
using Cadastro_Ponto_turistico.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Ponto_turistico.Controllers
{
    [ApiController]
    [Route("CadatroPontoTuristico")]
    public class TouristRegisterController : ControllerBase
    {
        private ITouristRegister _touristRegister;

        public TouristRegisterController(ITouristRegister touristRegister) 
        {
            _touristRegister = touristRegister; 
        }

        [HttpPost]
        public HttpResponseMessage Post(User user)
        {
            var touristResult = _touristRegister.Create(user);
            return touristResult;
        }
    }
}
