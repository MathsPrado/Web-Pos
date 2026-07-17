namespace Student.Web.Model
{
    public class PerfilEmpresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Sobre { get; set; }
        public string Segmento { get; set; }
        public string Site { get; set; }
        public string PasswordHash { get; set; }

        public System.Collections.Generic.ICollection<SolicitacaoProjeto> ProjetosAbertos { get; set; } = new System.Collections.Generic.List<SolicitacaoProjeto>();
    }
}
