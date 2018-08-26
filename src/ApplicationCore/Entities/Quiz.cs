using System;
using System.Collections;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Quiz :BaseEntity
    {
        public int QuizTypeId { get; set; }
        public DateTime QuizDate { get; set; }
        public int StudentId { get; set; }
        public decimal QuizScore { get; set; }
        public ICollection <QuizItem> QuizItems { get; set; } 
    }
}