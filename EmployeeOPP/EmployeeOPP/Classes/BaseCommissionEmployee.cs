namespace EmployeeOPP.Classes
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }


        #endregion

        #region Methods

        public BaseCommissionEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Base: {Base:C2}\n\t";
        }

        #endregion
    }
}
