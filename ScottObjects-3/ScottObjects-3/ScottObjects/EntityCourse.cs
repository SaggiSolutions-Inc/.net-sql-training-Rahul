using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottObjects
{
    public class EntityCourse 
    {
        public int EntityId { get;  set; }
        public int CourseId { get;  set; }
        public char Role { get;  set; } 
        public DateTime ActionDate { get;  set; }

        public EntityCourse(int entityId, int courseId, char role, DateTime actionDate)
        {
            EntityId = entityId;
            CourseId = courseId;
            Role = role;
            ActionDate = actionDate;
        }
    }
}
