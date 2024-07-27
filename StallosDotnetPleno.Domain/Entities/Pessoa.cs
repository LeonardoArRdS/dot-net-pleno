namespace StallosDotnetPleno.Domain.Entities
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        public byte TipoPessoaId { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }
    }
}
