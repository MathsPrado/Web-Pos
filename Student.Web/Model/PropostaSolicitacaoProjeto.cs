namespace Student.Web.Pages
{
    public class PropostaSolicitacaoProjeto
    {
        public int Id { get; set; }
        public string Descircao { get; set; }
        public int TempoEntrega { get; set; }
        public string Orçamento { get; set; }
        public int IdPropostaSolucao { get; set; }

        public int IdUsuario { get; set; }
    }
}
