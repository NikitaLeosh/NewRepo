using CsvImportSite.Models;
using System.ComponentModel.DataAnnotations;

namespace CsvImportSite.ViewModels
{
	public class IndexViewModel
	{
		/// <summary>
		/// File input for possible post Index method
		/// </summary>
		[FileExtensions(Extensions = ".csv", ErrorMessage = "Incorrect file format")]
		public IFormFile CsvFile { get; set; }
		/// <summary>
		/// Collection of employees for picturing the grid
		/// </summary>
		public IEnumerable<Employee> Employees { get; set; }

	}
}
