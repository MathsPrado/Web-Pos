namespace Student.Web.Model
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public string DataInicioFim { get; set; }
        public int PerfilUserId { get; set; }
    }
}
