using EmployeeOOP.Classes;

namespace EmployeeOPP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public int CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        public decimal SalaryC { get; set; }

        #endregion

        #region Methods


        public CommissionEmployee()
        {
        }

        BaseCommissionEmployee bcme = new BaseCommissionEmployee(); 
      
       

        public override decimal GetValueToPay()
        {
            SalaryC = bcme.GetValueToPay() + (Sales * (CommissionPercentaje / 100));

            return SalaryC;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Total: {SalaryC:C2}\n\t";
        }

        #endregion
    }
}
