using CommandLine;

namespace MirrorTask.Settings
{
    public class CommonOptions
    {
        [Option('d', "includesubdirectories", Required = false, HelpText = "Include all subdirectories when searching. Defaults to top level directory only.")]
        public bool IncludeSubDirectories { get; set; }
    }
}
