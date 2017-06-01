using System;

namespace PTS_eUniversity.Models
{
    public class Insurance
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime DateIssued { get; set; }

        public decimal Value { get; set; }
    }
}