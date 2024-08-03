using CollegeDetailsApp_List_.Model;

class Program
{
    static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "Datta Meghe College Of Engineering ");

        Student student1 = new Student(1, "Aditya");
        Student student2 = new Student(2, "Abhishek");

        college.students.Add(student1);
        college.students.Add(student2);

        Professor professor1 = new Professor(11, "Rohit sir ");
        Professor professor2 = new Professor(12, "Samruddhi mam");

        college.professors.Add(professor1);
        college.professors.Add(professor2);


        Department department1 = new Department(101, "Computer Engineering");
        Department department2 = new Department(102, "Computer Engineering");

        college.departments.Add(department1);
        college.departments.Add(department2);

        Menu.MainMenu(college);
    }
}
