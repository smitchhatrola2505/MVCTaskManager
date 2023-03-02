using MvcTaskManager.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcTaskManager.Models
{
	public class Skill
	{

		[Key]
		public int SkillID { get; set; }
		public string SkillName { get; set; }
		public string SkillLevel { get; set; }
		public string Id { get; set; }

		[ForeignKey("Id")]
		public virtual ApplicationUser ApplicationUser { get; set; }
	}
}
