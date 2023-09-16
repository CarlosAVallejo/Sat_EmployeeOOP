using EmployeeOOP.Classes;

namespace EmployeeOPP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }

        public decimal HourValue { get; set; }

        public decimal SalaryH { get; set; }

        #endregion

        #region Methods



        public HourlyEmployee()
        {
        }
        public override decimal GetValueToPay()
        {
            SalaryH = Hours * HourValue;

            return SalaryH;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado por Horas: {SalaryH:C2}\n\t";
        }



        #endregion

    }
}
