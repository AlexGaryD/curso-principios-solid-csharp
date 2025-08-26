using OpenClose;

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Juan Gómez", 260),
});



void ShowSalaryMonthly(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname} - Salario: {employee.ShowSalaryMonthly():C}");
    }
}