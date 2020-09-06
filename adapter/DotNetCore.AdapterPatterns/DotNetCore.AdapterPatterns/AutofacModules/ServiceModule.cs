using System.Collections.Generic;
using Autofac;
using Autofac.Features.Metadata;
using DotNetCore.AdapterPatterns.Services;

namespace DotNetCore.AdapterPatterns.AutofacModules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SaveCommand>().As<ICommand>().WithMetadata("Name", "Save");
            builder.RegisterType<OpenCommand>().As<ICommand>().WithMetadata("Name", "Open");

            builder.RegisterAdapter<Meta<ICommand>, ToolbarButton>(cmd => new ToolbarButton(cmd.Value, (string)cmd.Metadata["Name"]));
        }
    }
}
