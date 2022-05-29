using Cadastro_Ponto_turistico.Interface;
using Cadastro_Ponto_turistico.Model;
using Cadastro_Ponto_turistico.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestPontoTuristico
{
    public class TouristTest
    {
        private readonly ITouristRegister _touristRegister;

        public TouristTest()
        {
            _touristRegister = new TouristRegisterService();
        }

        [Fact]
        public void TouristServiceWhithUserNameNull()
        {
            var user = new User { Name = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("Name cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserDescriptionNull()
        {
            var user = new User { Name = "Murilo", State = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("Description cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserStateNull()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("State cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserCityNull()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = "São Paulo", City = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("City cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserResponsibleNull()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = "São Paulo", City = "Marilia", EmailResponsible = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("Responsible cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserEmailResponsibleNull()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = "São Paulo", City = "Marilia", Responsible = "Edson", EmailResponsible = null };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("EmailResponsible cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserPhoneResponsibleNull()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = "São Paulo", City = "Marilia", Responsible = "Edson", EmailResponsible = "Edson@gmail.com" };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Contains("PhoneResponsible cant be null", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }

        [Fact]
        public void TouristServiceWhithUserCreated()
        {
            var user = new User { Name = "Murilo", Description = "qualquer coisa", State = "São Paulo", City = "Marilia", Responsible = "Edson", EmailResponsible = "Edson@gmail.com", PhoneResponsible = "(14) 9 1234-5678" };

            var result = _touristRegister.Create(user);

            Assert.Equal(HttpStatusCode.Created, result.StatusCode);
            Assert.Contains("User created", result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }
    }
}
