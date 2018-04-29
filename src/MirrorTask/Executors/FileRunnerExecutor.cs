using MirrorTask.Queries;
using MirrorTask.Repositories;
using MirrorTask.Settings;
using MirrorTask.Translators;
using System;
using System.Diagnostics;
using System.IO;

namespace MirrorTask.Executors
{
    public static class FileRunnerExecutor
    {
        public static object Run(FileRunnerOptions fileRunnerOptions)
        {
            var directoryRepository = new FileDirectoryRepository(new FileQueries(), new FileDirectoryTranslator(), new ApplicationSettings());
            var directoriesToActOn = directoryRepository.DefaultDirectories();

            foreach (var directory in directoriesToActOn)
            {
                if (Directory.Exists(directory.AbsolutePath))
                {
                    var allFiles = Directory.GetFiles(directory.AbsolutePath);
                    foreach (var file in fileRunnerOptions.Files)
                    {
                        var fileToCall = Array.Find(allFiles, x => x.Contains(file));
                        if (fileToCall != null)
                        {
                            Process.Start("cmd", "/c \"" + fileToCall + "\"");
                        }
                    }
                }
            }

            return 1;
        }
    }
}
