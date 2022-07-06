using System.ComponentModel.DataAnnotations;
namespace Pomodoro.Model
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        public int priority { get; set; }
        public int pomodoros_done { get; set; }
        public int pomodoros_estimated { get; set; }
        public int finished { get; set; }
        public int text { get; set; }
        public int created_at { get; set; }
        public int finished_at { get; set; }
        public int unplanned { get; set; }
        public int deadline { get; set; }
        public int internal_interuptions { get; set; }
        public int external_interuptions { get; set; }
    }
}
