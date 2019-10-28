using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            if (context.Database.EnsureCreated())
            {
                // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
            new Student{FirstMidName="Carson",LastName="Alexander",CreateTime=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",CreateTime=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",CreateTime=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",CreateTime=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",CreateTime=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",CreateTime=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",CreateTime=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",CreateTime=DateTime.Parse("2005-09-01")}
                };
                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }
        }
    }
}
