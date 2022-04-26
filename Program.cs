using System;
using System.Collections.Generic;
using RecruitementSolution.Data;
using RecruitementSolution.Models;
using RecruitementSolution.Repositories;

namespace RecruitementSolution
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            ConfigurationHelper configurationHelper = ConfigurationHelper.Instance();

            var dbConnectionString = configurationHelper.GetProperty<string>("DbConnectionString");

            Console.Write("Enter employee code: ");
            string employeeCode = Console.ReadLine();
            Console.WriteLine("\n");

            using (RecruitmentContext context = new RecruitmentContext(dbConnectionString))
            {
                try
                {
                    EmployeeGenericRepository employeeGenericRepository = new EmployeeGenericRepository(context);
                    PositionGenericRepository positionGenericRepository = new PositionGenericRepository(context);
                    AnnualSalaryGenericRepository annualSalaryGenericRepository = new AnnualSalaryGenericRepository(context);
                    MonthlySalaryGenericRepository monthlySalaryGenericRepository = new MonthlySalaryGenericRepository(context);
                    EmployeeSkillGenericRepository employeeSkillRepository = new EmployeeSkillGenericRepository(context);

                    Employee employeeDetails = employeeGenericRepository.FindByCode(employeeCode);
                    Console.WriteLine($"EMPLOYEE CODE: {employeeDetails.CEmployeeCode}");
                    Console.WriteLine($"FIRST NAME: {employeeDetails.VFirstName}");
                    Console.WriteLine($"LAST NAME: {employeeDetails.VLastName}");

                    Position employeePosition = positionGenericRepository.GetPositionByCode(employeeDetails.CCurrentPosition);
                    Console.WriteLine($"POSITION: {employeePosition.VDescription}");

                    Console.WriteLine("\n");

                    List<AnnualSalary> employeeAnnualSalary = annualSalaryGenericRepository.GetAnnualSalaryByEmployeeCode(employeeCode);
                    Console.WriteLine("ANNUAL SALARY");
                    foreach (var annualSalary in employeeAnnualSalary)
                    {
                        Console.WriteLine($"Year: {annualSalary.SiYear}, Salary: {annualSalary.MAnnualSalary}");
                    };

                    Console.WriteLine("\n");

                    MonthlySalaryGenericRepository monthlySalaryRepository = new MonthlySalaryGenericRepository(context);
                    List<MonthlySalary> employeeMonthlySalary = monthlySalaryRepository.GetMonthlySalaryByEmployeeCode(employeeCode);

                    Console.WriteLine("MONTHLY SALARY");
                    foreach (var monthlySalary in employeeMonthlySalary)
                    {
                        Console.WriteLine($"Month: {monthlySalary.DPayDate}, Salary: {monthlySalary.MMonthlySalary}, Referral Bonus: {monthlySalary.MReferralBonus}");
                    };

                    Console.WriteLine("\n");

                    IEnumerable<dynamic> employeeSkills = employeeSkillRepository.GetEmployeeSkillsByEmployeeCode(employeeCode);
                    Console.WriteLine("EMPLOYEE SKILLS");
                    foreach (var employeeSkill in employeeSkills)
                    {
                        Console.WriteLine($"\t{employeeSkill.CSkillCode}");
                    };

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
