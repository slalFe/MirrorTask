using MirrorTask.Models;

namespace MirrorTask.Translators
{
    public class FileDirectoryTranslator
    {
        public TargetDirectory ToDomain(string line)
        {
            return new TargetDirectory { AbsolutePath = line };
        }
    }
}
