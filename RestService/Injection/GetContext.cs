using RestService.Models;

namespace RestService.Singleton
{
    public class GetContext
    {
        private static ProjectContext instance { get; set; }
        private GetContext()
        {
            if (instance == null)
                instance = new ProjectContext();
        }

        public static ProjectContext GetInstance()
        {
            if (instance == null)
                instance = new ProjectContext();
            return instance;
        }

    }
}