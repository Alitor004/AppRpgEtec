using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppRpgEtec.Services;
using AppRpgEtec.Models.Usuarios;

namespace AppRpgEtec.Services.Usuarios
{
    public class UsuarioService : Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "http://alitor004.somme.com.RpgApi/Usuarios";

        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            //Registrar: Rota para o método na API que registrar o usuário
            string urlComplementar = "/Rgistrar";
            u.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, u);
            return u;
        }

        public async Task<Usuario> PostAutentyicarUsuarioAsync(Usuario u)
        {
            //Autenticar: Rota para o método na API que autentica com login e senha
            string urlComlementar = "/Autenticar";
            u = await _request.PostAsync(apiUrlBase + urlComlementar, u, string.Empty);

            return u;
        }
    }
}
