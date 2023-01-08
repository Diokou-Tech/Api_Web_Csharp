using api_web.Interfaces;

namespace api_web.Models
{
    public class StudentDB : ISettingDB
    {
        public string StudentCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get ; set ; } = string.Empty;
        public string DatabaseName { get ; set ; } = string.Empty;
    }
}
