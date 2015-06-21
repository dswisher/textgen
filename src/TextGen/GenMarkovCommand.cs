using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaclops;
using Yaclops.Attributes;

namespace TextGen
{
    [Summary("Scan one or more documents, build one (or more) Markov Chains, and write them to file(s).")]
    public class GenMarkovCommand : ISubCommand
    {

        public GenMarkovCommand()
        {
        }



        [PositionalParameter, Required]
        [Description("The name(s) of the files to scan, which may include wildcards.")]
        public List<string> Files { get; set; }



        public void Execute()
        {
            foreach (var file in GetFiles())
            {
                Console.WriteLine("{0}", file.FullName);
            }
        }



        private IEnumerable<FileInfo> GetFiles()
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var name in Files)
            {
                var dirName = Path.GetDirectoryName(name);
                var fileName = Path.GetFileName(name);

                if (string.IsNullOrEmpty(dirName))
                {
                    continue;
                }

                var dirInfo = new DirectoryInfo(dirName);

                var files = dirInfo.GetFiles(fileName);

                foreach (var file in files)
                {
                    yield return file;
                }
            }
        }
    }
}
