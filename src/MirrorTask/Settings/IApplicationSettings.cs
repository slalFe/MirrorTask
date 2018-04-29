namespace MirrorTask.Settings
{
    public interface IApplicationSettings
    {
        string FileStorageDirectory { get; }
        string DefaultDirectoriesFileName { get; }
    }
}