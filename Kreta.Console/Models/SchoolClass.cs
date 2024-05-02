namespace Kreta.Console.Models
{
    public class SchoolClass
    {
        public SchoolClass()
        {                
        }

        public SchoolClass(Guid id, int schoolYear, char classType)
        {
            Id = id;
            SchoolYear = schoolYear;
            ClassType = classType;
        }

        public Guid Id { get; set; }
        public int SchoolYear { get; set; } // 9.
        public char ClassType { get; set; } // 'c'

        public override string ToString()
        {
            return $"{SchoolYear}.{ClassType}";
        }
    }
}
