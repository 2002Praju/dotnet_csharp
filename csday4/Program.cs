public class Student
{
    int Id { get; set; } //private
    public string Name { get; set; }
    public string Address { get; set; }
    public Student(int id)
    {
        this.Id = id;
    }
}
//Logical Class => Class
public class StudentOperations
{
    List<Student>students;
    public void Add(Student st){
        students.Add(st);
    }
    public void DisplayDetails(Student st)
    {
        Console.WriteLine($"Name:{st.Name}, Address:{st.Address}");
    }
    public List<Student>GetAll(){
        return students;
    }
}
public class Program
{
    public static void Main()
    {
        Student st = new Student(2);
        st.Name="Mohan";
        st.Address = "Noida";


        StudentOperations stoperations = new StudentOperations();
        stoperations.DisplayDetails(st);
    }
}
