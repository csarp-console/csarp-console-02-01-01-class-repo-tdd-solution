using Kreta.Console.Models;

namespace Kreta.Console.Repos
{
    class SubjectRepo
    {
        #region Database
        private List<Subject> subjects = new()
        {
            new Subject
            {
                ID=Guid.NewGuid(),
                SubjectName="Történelem"
            },
            new Subject
            {
                ID=Guid.NewGuid(),
                SubjectName="Földrajz"
            }
        };
        #endregion

        public List<Subject> FindAll()
        {
            return subjects;
        }
    }
}
