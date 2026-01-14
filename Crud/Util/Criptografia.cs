using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Util
{
    class Criptografia
    {
        public static string GerarSHA256(string texto)
        {
            SHA256 sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(texto)); //onde acontece a criptografia
            return BitConverter.ToString(hash).Replace("-", "").ToLower(); // conversão do byte para string legível
        }
    }


}
