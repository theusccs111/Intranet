using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Intranet.Models
{
    public class UsuarioDAL
    {
        public bool SalvarUsuario(Usuario registro)
        {
            using (var context = new Context())
            {
                context.Usuario.Add(registro);
                var usuarioSalvo = context.SaveChanges();
                return usuarioSalvo >= 1;
            }
        }
        public Usuario GetUsuarioPorCodigo(int codigo)
        {
            using (var context = new Context())
            {
                return context.Usuario.FirstOrDefault(u => u.id == codigo);
            }
        }
        public List<Usuario> GetUsuarios()
        {
            try
            {
                using (var context = new Context())
                {
                    return context.Usuario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario GetUsuarioPorLoginSenha(Usuario registro)
        {
            using (var context = new Context())
            {
                return context.Usuario.FirstOrDefault(u => u.login == registro.login && u.senha == registro.senha);
            }
        }

        public string Cifrar(string textoPuro)
        {
            string chaveCifragem = "MACVS2014XYW";
            byte[] bytesLimpos = Encoding.Unicode.GetBytes(textoPuro);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCifragem, new byte[]
 { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesLimpos, 0, bytesLimpos.Length);
                        cs.Close();
                    }
                    textoPuro = Convert.ToBase64String(ms.ToArray());
                }
            }
            return textoPuro;
        }
        public string Decifrar(string textoCifrado)
        {
            string chaveCifragem = "MACVS2014XYW";
            byte[] bytesCifrados = Convert.FromBase64String(textoCifrado);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chaveCifragem, new byte[]
{ 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesCifrados, 0, bytesCifrados.Length);
                        cs.Close();
                    }
                    textoCifrado = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return textoCifrado;
        }
    }
}