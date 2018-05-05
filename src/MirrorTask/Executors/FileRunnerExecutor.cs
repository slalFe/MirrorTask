using MirrorTask.Queries;
using MirrorTask.Repositories;
using MirrorTask.Settings;
using MirrorTask.Translators;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MirrorTask.Executors
{
    public static class FileRunnerExecutor
    {
        public static object Run(FileRunnerOptions fileRunnerOptions)
        {
            var directoryRepository = new FileDirectoryRepository(new FileQueries(), new FileDirectoryTranslator(), new ApplicationSettings());
            var directoriesToActOn = directoryRepository.DefaultDirectories();
            var directorySearchOption = fileRunnerOptions.IncludeSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var filesToCall = new List<string>();

            foreach (var directory in directoriesToActOn)
            {
                if (Directory.Exists(directory.AbsolutePath))
                {
                    var allFilePaths = Directory.GetFiles(directory.AbsolutePath, "*", directorySearchOption);

                    foreach (var targetFileName in fileRunnerOptions.Files)
                    {
                        filesToCall.AddRange(allFilePaths.Where(filePath => filePath.EndsWith(targetFileName)));
                    }
                }
            }

            var distinctFilesToCall = filesToCall.Distinct();

            foreach (var fileToCall in distinctFilesToCall)
            {
                Process.Start("cmd", "/c \"" + fileToCall + "\"");
            }

            return 1;
        }
    }
}
