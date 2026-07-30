namespace Student.Web.Model
{
    public class PerfilUser
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Biografia { get; set; }
        public string FotoBase64 { get; set; }
        public string Cidade { get; set; }
        public string Faculdade { get; set; }
        public bool CursandoFaculdade { get; set; }

        public System.Collections.Generic.ICollection<UserSkill> Skills { get; set; } = new System.Collections.Generic.List<UserSkill>();
        public System.Collections.Generic.ICollection<WorkExperience> Experiences { get; set; } = new System.Collections.Generic.List<WorkExperience>();
        public System.Collections.Generic.ICollection<AcademicBackground> Formacoes { get; set; } = new System.Collections.Generic.List<AcademicBackground>();
    }
}
