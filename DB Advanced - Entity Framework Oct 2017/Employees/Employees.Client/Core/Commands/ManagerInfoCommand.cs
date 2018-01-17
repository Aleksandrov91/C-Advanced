namespace Employees.Client.Core.Commands
{
    using System;
    using System.Text;

    using Employees.Client.Contracts;
    using Employees.Client.Models;
    using Employees.Services.Contracts;

    internal class ManagerInfoCommand : ICommand
    {
        private IEmployeeService employeeService;

        public ManagerInfoCommand(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        public string Execute(string[] data)
        {
            if (data.Length != 1)
            {
                throw new InvalidOperationException("Invalid parameters");
            }

            int managerId = int.Parse(data[0]);

            ManagerInfoDto manager = this.employeeService.MangerInfo<ManagerInfoDto>(managerId);

            StringBuilder managerInfo = new StringBuilder();

            managerInfo.AppendLine($"{manager.FirstName} {manager.LastName} | Employees: {manager.ManagedEmployeesCount}");
            foreach (var employee in manager.ManagedEmployees)
            {
                managerInfo.AppendLine($"  - {employee.FirstName} {employee.LastName} - ${employee.Salary:F2}");
            }

            return managerInfo.ToString().Trim();            
        }
    }
}
