using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace GorillaTest.Model
{
    public class StudentModel
    {
        public StudentModel()
        {
        }
        public StudentModel(int id, string name, string gender, int age, string lastname)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            Lastname = lastname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Lastname { get; set; }

        public static ObservableCollection<StudentModel> GetMenu()
        {
            ObservableCollection<StudentModel> result = new ObservableCollection<StudentModel>();
            result.Add(new StudentModel(1, "Fabian", "male", 32, "Campos"));
            result.Add(new StudentModel(2, "Francisco", "male",31, "McCorney"));
            result.Add(new StudentModel(3, "Rolando", "male",32, "Perez"));


            return result;
        }
    }
}
