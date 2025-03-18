using System;
using System.Collections.Generic;

namespace EFcoreDatabaseFirst.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
