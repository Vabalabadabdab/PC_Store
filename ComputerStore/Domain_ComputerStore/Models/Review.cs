using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_ComputerStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CostRate { get; set; }
        public int QualityRate { get; set; }
        public int FuncRate { get; set; }
        public float AvgRate { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Comment { get; set; }
        public bool IsRecommend { get; set; }
        public Guid UserId { get; set; }
        public int GroupReviewId { get; set; }
        public DateTime WriteTime { get; set; }
        public User User { get; set; }
        public GroupReview GroupReview { get; set; }
    }
}
