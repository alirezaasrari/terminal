namespace Terminal.Model
{
    public class DataLoggers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? SoftwareVersion { get; set; }
        public string? HardwareVersion { get; set; }
        public string? Serial { get; set; }
        public string? Apn { get; set; }
        public string? Protocol { get; set; }
        public string? IP { get; set; }
        public int? Port { get; set; }
        public int? DailyServerReportCount { get; set; }
        public string? CheckMeterAlarm { get; set; }
        public string? ReportTime { get; set; }
        public int? CityId { get; set; }
        public string? Address { get; set; }
        public int DataLoggerTypeId { get; set; }
        public string? Mobile { get; set; }
        public DateTime? InstallDate { get; set; }
        public int? AreaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? SecondaryUsers { get; set; }
        public string? GeoLocation { get; set; }
        public int CreatorId { get; set; }
    }
}
