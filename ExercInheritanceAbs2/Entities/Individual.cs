namespace ExercInheritanceAbs2.Entities 
{
    internal class Individual : TaxPayer
    {
        public double  HealthCharges { get; set; }

        public Individual(string name, double anualIncome, double healthCharges) 
            :base(name, anualIncome)
        {
            HealthCharges = healthCharges;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome > 20000.00)
            {
                return (AnualIncome * 2.5) - (HealthCharges * 5.0);
            }
            else
            {
                return (AnualIncome * 1.5) - (HealthCharges * 5.0);
            }
        }
    }
}
