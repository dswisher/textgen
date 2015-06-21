﻿using System;
using System.Diagnostics;
using System.Reflection;
using Autofac;
using Yaclops;

namespace TextGen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = CreateContainer();

                var parser = container.Resolve<CommandLineParser>();

                var command = parser.Parse(args);

                command.Execute();
            }
            catch (CommandLineParserException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled exception in main.");
                Console.WriteLine(ex);
            }

            if (Debugger.IsAttached)
            {
                Console.Write("<press ENTER to continue>");
                Console.ReadLine();
            }
        }



        private static IContainer CreateContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<TokenizerFactory>().As<ITokenizerFactory>();
            builder.RegisterType<TokenizerFactory>().As<ITokenizer>();

            // Command-line specific stuff
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => typeof(ISubCommand).IsAssignableFrom(t) && t.IsPublic)
                .SingleInstance()
                .As<ISubCommand>();

            builder.RegisterType<CommandLineParser>();

            return builder.Build();
        }
    }
}
