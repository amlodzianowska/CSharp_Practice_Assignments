using System.ComponentModel.DataAnnotations;
namespace weddingPlanner.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId {get;set;}
        public int UserId {get;set;}
        public int WeddingId {get;set;}
        public User Guest {get;set;}
        public Wedding Wedding {get;set;}
    }
}