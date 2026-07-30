using System;

namespace Student.Web.Model
{
    public class AcademicBackground
    {
        public int Id { get; set; }
        public string Instituicao { get; set; }
        public string Curso { get; set; }
        public string DataInicioFim { get; set; }
        public bool CursandoAtualmente { get; set; }
        public int PerfilUserId { get; set; }
    }
}
