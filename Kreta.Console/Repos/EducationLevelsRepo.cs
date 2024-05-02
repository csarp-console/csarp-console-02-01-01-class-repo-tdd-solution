namespace Kreta.Console.Repos
{
    public class EducationLevelsRepo
    {
        #region Database
        private List<String> _educationLevels= new() { "érettségi", "szakképzés", "szakmai vizsga" };
        #endregion

        public List<string> FindAll()
        {
            return _educationLevels;
        }
    }
}
