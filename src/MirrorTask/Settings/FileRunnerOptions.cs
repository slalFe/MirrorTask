using CommandLine;
using System.Collections.Generic;

namespace MirrorTask.Settings
{
    [Verb("filerunner", HelpText = "Run scripts such as batch (.bat) files.")]
    public class FileRunnerOptions : CommonOptions
    {
        [Option('f', "files", Required = true, HelpText = "Files to run.")]
        public IEnumerable<string> Files { get; set; }
    }
}
