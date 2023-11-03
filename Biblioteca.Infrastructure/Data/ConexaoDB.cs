using Biblioteca.Domain.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure.Data
{    
    public class ConexaoDB : IConexaoDB
    {
        private readonly IConfiguration _config;
        public ConexaoDB(IConfiguration config)
        {
            _config = config;
        }

        public string GetConexao()
        {
            try
            {
                string conn = Convert.ToString(_config.GetSection("Data:ConnectionString").Value);

                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
