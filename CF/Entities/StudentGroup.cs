using System.Data;

namespace CF.Entities
{
    public class StudentGroup
    {
        public int IdGroup { get; set; }

        public int IdStudent { get; set; }

        public DateTime AddedAt { get; set; }

        public virtual Student Student { get; set; }

        public virtual Group Group { get; set; }
    }
}
