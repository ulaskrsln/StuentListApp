using System.ComponentModel.DataAnnotations;

namespace EF_Test.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolNumber { get; set; }
        public string Department { get; set; }
        public int Grade { get; set; }

    }
}
