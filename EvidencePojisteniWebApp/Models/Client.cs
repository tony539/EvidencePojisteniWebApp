using System.ComponentModel.DataAnnotations;

namespace EvidencePojisteniWebApp.Models
{
	public class Client
	{
		/// <summary>
		/// Identifikační číslo pojištěnce
		/// </summary>
		[Display(Name = "Číslo pojištěnce")]
		public int Id { get; set; }
		[Display(Name = "Číslo pojistné smlouvy")]
		public int NumberOfInsuranceContract { get; set; }
		[Display(Name = "Jméno")]
		public string FirstName { get; set; } = "";
		[Display(Name = "Příjmení")]
		public string LastName { get; set; } = "";
		/// <summary>
		/// Sjednané pojištění
		/// </summary>
		[Display(Name = "Sjednané pojištění")]
		public string Insurance { get; set; } = "";
		[Display(Name = "Telefonní číslo")]
		public string PhoneNumber { get; set; } = "";
		[Display(Name = "Email")]
		public string Email { get; set; } = "";
	}
}
