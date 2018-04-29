namespace MirrorTask.Settings
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string FileStorageDirectory { get { return @"C:\Projects\MirrorTask\FileStorage\"; } }
        public string DefaultDirectoriesFileName { get { return @"DefaultDirectories.txt"; } }
    }
}
