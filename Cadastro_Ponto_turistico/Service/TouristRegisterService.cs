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
    public class TouristRegisterService : ITouristRegister
    {
        public HttpResponseMessage Create(User user)
        {
            var content = new HttpResponseMessage();
            try
            {

                if (String.IsNullOrEmpty(user.Name))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("Name cant be null");
                }
                else if (String.IsNullOrEmpty(user.Description))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("Description cant be null");
                }

                else if (String.IsNullOrEmpty(user.State))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("State cant be null");
                }
                else if (String.IsNullOrEmpty(user.City))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("City cant be null");
                }
                else if (String.IsNullOrEmpty(user.Responsible))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("Responsible cant be null");
                }
                else if (String.IsNullOrEmpty(user.EmailResponsible))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("EmailResponsible cant be null");
                }
                else if (String.IsNullOrEmpty(user.PhoneResponsible))
                {
                    content.StatusCode = HttpStatusCode.BadRequest;
                    content.Content = new StringContent("PhoneResponsible cant be null");
                }
                else
                {
                    //cria usuario
                    content.StatusCode = HttpStatusCode.Created;
                    content.Content = new StringContent("User created");
                }

                return content;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
