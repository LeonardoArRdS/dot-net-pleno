using System.ComponentModel;

namespace StallosDotnetPleno.Domain.Entities
{
    public enum TipoPessoa
    {
        [Description("Pessoa Física")]
        PF = 1,

        [Description("Pessoa Jurídica")]
        PJ = 2
    }
}
