using SuneduCRUD.Enum;
using System;

namespace SuneduCRUD.Models
{
	public class Docente
	{
		public int DocenteId { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Dni { get; set; }
		public string Sexo { get; set; }
		public string Estudios { get; set; }
		public EstadoContratacion EstadoContratacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Otro { get; set; }
	}
}