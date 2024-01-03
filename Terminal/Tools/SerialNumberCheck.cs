using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Terminal.Context;

namespace Terminal.Tools
{
    public static class SerialNumberCheck
    {
        public static int SerialCheck(string number)
        {
            var services = new ServiceCollection();
            var connectionString = "server=62.106.95.104;port=3306;database=talayieh;user=root;password=1372328$oheiL!@#$!;";
            services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            var serviceProvider = services.BuildServiceProvider();
            using var scope = serviceProvider.CreateScope();
            var db = scope.ServiceProvider.GetService<DataContext>();

            if (db.data_loggers.Where(l => l.Serial == number).Any() || db.datalogger.Where(l => l.Id_Number == number).Any())
            {
               return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
