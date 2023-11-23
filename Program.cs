namespace Company {
    public static class Program {
        public static Employee? CreateEmployee() {
            Console.Write("Nombre: ");
            string? name = Console.ReadLine();
            Console.Write("Salario: ");
            string? salaryString = Console.ReadLine();

            if (salaryString != null && name != null)
                return new Employee(name, decimal.Parse(salaryString));
            else
                return null;
        }

        public static Manager? CreateManager() {
            Console.Write("Nombre: ");
            string? name = Console.ReadLine();

            Console.Write("Salario: ");
            string? salaryString = Console.ReadLine();

            Console.Write("Departamento: ");
            string? department = Console.ReadLine();

            if (salaryString != null && name != null && department != null)
                return new Manager(name, decimal.Parse(salaryString), department);
            else
                return null;
        }

        public static void Main(string[] args) {
            Console.WriteLine("[ ACTIVIDAD PROGRAMACION ORIENTADA A OBJETOS EN C# ]\n");

            Console.WriteLine("[ Empleado ]");
            Employee? employee = CreateEmployee();
            employee?.Present();

            Console.WriteLine("\n[ Gerente ]");
            Manager? manager = CreateManager();
            manager?.Present();
        }
    }
}