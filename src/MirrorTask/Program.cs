using CommandLine;
using MirrorTask.Executors;
using MirrorTask.Settings;
using System;

namespace MirrorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<FileRunnerOptions>(args)
                .MapResult(
                    (FileRunnerOptions options) => FileRunnerExecutor.Run(options)
                    , errs => 1);

            Console.Read();
        }
    }
}
