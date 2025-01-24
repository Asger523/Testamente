using System.ComponentModel.DataAnnotations;

namespace Testamente.Models
{
	public class Langelænder
	{
		public int Id { get; set; }
		
		public string Name { get; set; }
		public string Birthday { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public RelationshipStatus RelationshipStatus { get; set; }
		
	}
}
