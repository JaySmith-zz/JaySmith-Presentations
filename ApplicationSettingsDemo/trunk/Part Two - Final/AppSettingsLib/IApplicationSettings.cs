namespace AppSettingsLib
{
    public interface IApplicationSettings
    {
        string Server { get; }
        string UserName();
        string Password();
    }
}