namespace Paskaita_3_inheritance
{
    public class Manager : Employee
    {
        public Manager(string name, int salary, List<Employee> employees) : base(name, salary)
        {
        }
        public List<Employee> Employess { get; set; }
    }
}
