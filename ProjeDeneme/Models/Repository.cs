using System.Collections.Generic;
namespace ProjeDeneme.Models

{
    public static class Repository
    {
        private static List<Student> _students=new List<Student>();

        public static List<Student> GetStudent{
            get
            {
                    return _students;
            }
        }
        public static void AddStudent(Student student){
                _students.Add(student);
        }
    }
    
}