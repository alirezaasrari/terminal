using Microsoft.EntityFrameworkCore;
using Terminal.Model;

namespace Terminal.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Log> NewTerminal { get; set; }
        public DbSet<Error> NewTerminalError { get; set; }
        public DbSet<SocketErrors> NewTerminalSocketError { get; set; }
        public DbSet<IoError> NewTerminalIoError { get; set; }
        public DbSet<DataLoggers> data_loggers { get; set; }
        public DbSet<DataLogger> datalogger { get; set; }
    }
}
