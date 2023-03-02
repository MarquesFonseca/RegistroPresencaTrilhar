using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilhar.Uteis
{
    public enum EstadoFormularioCadastro
    {
        Inicio,
        Novo,
        NovoAproveitando,
        Alterar,
        Excluir,
        Sincronizando,
        Preenchido,
        Cancelar
    }
}
