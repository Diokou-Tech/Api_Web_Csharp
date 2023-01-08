namespace api_web.Interfaces
{
    public interface ISettingDB
    {
        string StudentCollectionName { set; get; }
        string ConnectionString { set; get; }
        string DatabaseName { set; get; }
    }
}
