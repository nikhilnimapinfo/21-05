﻿using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Author
        {
            public Author()
            {
                Courses = new HashSet<Course>();
            }

            public int Id { get; set; }

            public string Name { get; set; }

            public virtual ICollection<Course> Courses { get; set; }
        }
}