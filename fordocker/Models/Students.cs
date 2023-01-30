using System.ComponentModel.DataAnnotations;

namespace fordocker.Models
{
    public class Students
    {
        [Key]
        public int StudentID { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;
    }
}
