using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
	internal class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public void GetData()
		{
			Console.WriteLine("Enter Employee Id");
			this.Id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Employee Name");
			this.Name = Console.ReadLine();

			Console.WriteLine("Enter Employee Adress");
			this.Address = Console.ReadLine();
		}

		public void PutData()
		{
			Console.WriteLine($"Employee Id = {this.Id}");
			Console.WriteLine($"Employee Name = {this.Name}");
			Console.WriteLine($"Employee Adress = {this.Address}");

		}

	}
}
