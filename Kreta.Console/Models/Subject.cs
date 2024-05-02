namespace Kreta.Console.Models
{
    public class Subject
    {
        public Subject() { }

        public Subject(Guid iD, string subjectName)
        {
            ID = iD;
            SubjectName = subjectName;
        }

        public Guid ID { get; set; } = Guid.Empty; 
        public string SubjectName { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"{SubjectName}";
        }
    }
}
