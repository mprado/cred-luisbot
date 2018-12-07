using LuisBot.Data;
using LuisBot.Models;
using System.Linq;

namespace LuisBot.Repositories
{
    public class PARepository
    {
        public Filial ObterPorNumero(int numero)
        {
            return OfflineData.Filiais.FirstOrDefault(c => c.Numero == numero);
        }

        public Filial ObterPorMunicipio(string municipio)
        {
            return OfflineData.Filiais.FirstOrDefault(c => c.Municipio == municipio);
        }
    }
}