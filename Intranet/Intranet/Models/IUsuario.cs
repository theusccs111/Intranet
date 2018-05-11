using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Models
{
    public interface IUsuario
    {
        bool SalvarUsuario(Usuario registro);
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioPorLoginSenha(Usuario registro);
        Usuario GetUsuarioPorCodigo(int codigo);
    }
}
