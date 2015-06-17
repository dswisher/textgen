using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            foreach (var name in Files)
            {
                Console.WriteLine("File: {0}", name);
            }
            // TODO
        }
    }
}
