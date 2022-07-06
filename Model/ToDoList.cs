using System.ComponentModel.DataAnnotations;
namespace Pomodoro.Model
{
    public class ToDoList
    {
        [Key]
        public int Id { get; set; }
        public int place { get; set; }
        public int date { get; set; }
    }
}
