using System.Collections.Generic;
using System.Linq;
using MirrorTask.Models;
using MirrorTask.Queries;
using MirrorTask.Settings;
using MirrorTask.Translators;

namespace MirrorTask.Repositories
{
    public class FileDirectoryRepository : IDirectoryRepository
    {
        private readonly FileQueries fileQueries;
        private readonly FileDirectoryTranslator fileDirectoryTranslator;
        private readonly IApplicationSettings applicationSettings;

        public FileDirectoryRepository(FileQueries fileQueries, FileDirectoryTranslator fileDirectoryTranslator, IApplicationSettings applicationSettings)
        {
            this.fileQueries = fileQueries;
            this.fileDirectoryTranslator = fileDirectoryTranslator;
            this.applicationSettings = applicationSettings;
        }

        public List<TargetDirectory> DefaultDirectories()
        {
            var directoryFileLines = fileQueries.ReadLinesFromFile(applicationSettings.FileStorageDirectory, applicationSettings.DefaultDirectoriesFileName);
            var directories = directoryFileLines.Select(x => fileDirectoryTranslator.ToDomain(x));
            return directories.ToList();
        }
    }
}
