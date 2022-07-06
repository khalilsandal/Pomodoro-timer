using System.ComponentModel.DataAnnotations;

namespace Pomodoro.Model
{
    public class Pomodoro
    {
        [Key]
        public int Id { get; set; }
        public int pomodoro_time { get; set; }
        public int short_breack_time { get; set; }
        public int long_breack_time { get; set; }
    }
}
