using System.ComponentModel.DataAnnotations;
namespace Pomodoro.Model
{
    public class Timer
    {
        [Key]
        public int Id { get; set; }

        public int total_time { get; set; }
        public int current_time { get; set; }
        public int tick_volume { get; set; }
        public int ring_volume { get; set; }
    }
}
