namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Department department = new Department();
            Student stuLiya = new Student()
            {
                name = "Liya",
                email = "XXX@gmail.com",
                phone = "09XX-XXX-XXX",
                department = new Department { departmentName = "資工系", sophomore = "3年", group = new Group { groupName = "A組" } }
            };

            System.Console.WriteLine(stuLiya.name);
            System.Console.WriteLine(stuLiya.email);
            System.Console.WriteLine(stuLiya.phone);
            System.Console.WriteLine(stuLiya.department.departmentName);
            System.Console.WriteLine(stuLiya.department.sophomore + stuLiya.department.group.groupName);
        }
    }
}