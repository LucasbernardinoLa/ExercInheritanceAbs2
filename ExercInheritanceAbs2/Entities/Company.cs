namespace ExercInheritanceAbs2.Entities
{
    internal class Company : TaxPayer
    {
        public int EmpNumber { get; set; }

        public Company(string name, double anualIncome, int empNumber)
            :base(name, anualIncome)
        {
            EmpNumber = empNumber;
        }

        public override double TaxesPaid()
        {
            if (EmpNumber > 10)
            {
                return AnualIncome * 1.4;
            }
            else
            {
                return AnualIncome * 1.6;
            }
        }
    }
}
