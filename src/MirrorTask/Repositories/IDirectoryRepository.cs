using MirrorTask.Models;
using System.Collections.Generic;

namespace MirrorTask.Repositories
{
    public interface IDirectoryRepository
    {
        List<TargetDirectory> DefaultDirectories();
    }
}
