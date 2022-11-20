using Autofac;
using Evdok.BLL.Controllers;
using Evdok.BLL.Interfaces;

namespace Evdok.Core
{
    public class Container
    {
        public static IContainer config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WorkerController>().As<IWorkerController>();
            builder.RegisterType<ExcelController>().As<IExcelController>();
            builder.RegisterType<SqlController>().As<ISqlController>();
            builder.RegisterType<XokController>().As<IXokController>();
            builder.RegisterType<RkoController>().As<IRkoController>();
            builder.RegisterType<MailController>().As<IMailController>();

            return builder.Build();
        }
    }
}
