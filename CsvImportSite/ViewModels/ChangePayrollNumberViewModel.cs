using System.ComponentModel.DataAnnotations;

namespace CsvImportSite.ViewModels
{
	public class ChangePayrollNumberViewModel
	{
		//View model for safe demonstration of properties of employee being changed
		public string Payroll_Number { get; set; }
		[MaxLength(10, ErrorMessage = "Payroll number can not be longer then 10 charcters")]
		public string NewPayroll_Number { get; set; }
		public string Forenames { get; set; }
		public string Surname { get; set; }
	}
}
