using System.Data.Entity;
using SuneduCRUD.Models;

namespace SuneduCRUD
{
	public class SuneduContext : DbContext
	{
		public DbSet<Docente> Docentes { get; set; }
	}
}