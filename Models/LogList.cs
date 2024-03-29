﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LogList
    {
        public int Id { get; set; }
        public string LogMessage { get; set; }

        public DateTime LogDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
