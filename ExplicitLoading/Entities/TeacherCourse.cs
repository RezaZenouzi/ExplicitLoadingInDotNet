﻿namespace ExplicitLoading.Entities
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
