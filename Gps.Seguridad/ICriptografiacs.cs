using System;
using System.Collections.Generic;
using System.Text;

namespace Gps.Seguridad
{
   public interface ICriptografiacs
    {
         string Decrypt(string encryptedText);
         string Encrypt(string plainText);



    }
}
