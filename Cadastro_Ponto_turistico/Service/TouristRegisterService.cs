using Cadastro_Ponto_turistico.Interface;
using Cadastro_Ponto_turistico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Cadastro_Ponto_turistico.Service
{
    internal class TouristRegisterService : ITouristRegister
    {
        public User Create(User user)
        {
            if (String.IsNullOrEmpty(user.Name))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.Description))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.State))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.City))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.Responsible))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.EmailResponsible))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (String.IsNullOrEmpty(user.PhoneResponsible))
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            return user;
        }
    }
}
