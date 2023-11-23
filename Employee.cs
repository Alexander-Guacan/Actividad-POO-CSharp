namespace Company {
    public class Employee : IShowInformation {
        private readonly string mName;
        private readonly decimal mSalary;

        public Employee(string name, decimal salary) {
            mName = name;
            mSalary = salary;
        }

        public decimal ComputeAnualSalary() {
            return mSalary * 12m;
        }

        public virtual void Present() {
            Console.WriteLine(
                $"Nombre: {mName}\n"
                + $"\tSalario: {mSalary}\n"
                + $"\tSalario anual: {ComputeAnualSalary()}"
            );
        }
    }
}