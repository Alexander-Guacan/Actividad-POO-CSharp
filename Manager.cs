namespace Company {
    public class Manager : Employee {
        private readonly string mDepartment;
        public Manager(string name, decimal salary, string department) : base(name, salary) {
            mDepartment = department;
        }

        public override void Present() {
            base.Present();
            Console.WriteLine(
                $"\tDepartamento: {mDepartment}"
            );
        }
    }
}