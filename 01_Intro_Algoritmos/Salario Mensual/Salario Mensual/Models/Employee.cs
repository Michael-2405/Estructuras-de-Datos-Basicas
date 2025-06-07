using Salario_Mensual.Interfaces;

namespace Salario_Mensual.Models
{
  public class Employee: ISalaryCalculator
  {
    public string Name { get; }
    public double HoursPerWeek { get; }
    public double HourlyRate { get; }

    public Employee(string name, double hoursPerWeek, double hourlyRate)
    {
      Name = name;
      HoursPerWeek = hoursPerWeek;
      HourlyRate = hourlyRate;
    }

    public virtual double CalculateWeeklySalary()
    {
      const double maxRegularHours = 40;
      if (HoursPerWeek <= maxRegularHours)
      {
        return HoursPerWeek * HourlyRate;
      }
      else
      {
        double overtimeHours = HoursPerWeek - maxRegularHours;
        double regularPay = maxRegularHours * HourlyRate;
        double overtimePay = overtimeHours * HourlyRate * 1.5;
        return regularPay + overtimePay;
      }
    }
    public double CalculateMonthlySalary()
    {
      return CalculateWeeklySalary() * 4;
    }
  }
}
