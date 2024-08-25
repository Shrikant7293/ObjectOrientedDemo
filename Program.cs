

using ObjectOrientedDemo;

class Program() { 
public static void Main()
{
		//CreateEmployee();

		Employee employee = new Employee();
		employee.GetData();
		employee.PutData();


	}

	public static void CreateEmployee()
	{
		Employee employee = new Employee();
		employee.Id = 10;
		employee.Name = "Array";
		employee.Address = "Ahemdabad";

		Console.WriteLine($"Employee Id = {employee.Id}");
		Console.WriteLine($"Employee Name = {employee.Name}");
		Console.WriteLine($"Employee Adress = {employee.Address}");

		Console.WriteLine("-----------------------------------------------------------------");

		Employee employee1 = new Employee();
		employee1.Id = 10;
		employee1.Name = "String";
		employee1.Address = "Surat";

		Console.WriteLine($"Employee1 Id = {employee1.Id}");
		Console.WriteLine($"Employee1 Name = {employee1.Name}");
		Console.WriteLine($"Employee1 Adress = {employee1.Address}");
	}

}