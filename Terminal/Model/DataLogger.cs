namespace Terminal.Model
{
    public class DataLogger
    {
        public int Id { get; set; }
        public string Guid { get; set; } = string.Empty;
        public string Id_Number { get; set; } = string.Empty;
        public string? TypeId { get; set; }
        public string SimCardNumber { get; set; } = string.Empty;
        public DateTime? InstallationDate { get; set; }
        public string InstallationLocation { get; set; } = string.Empty;
        public string GisCode { get; set; } = string.Empty;
        public int AbfaAreaId { get; set; }
        public string Mobile { get; set; } = string.Empty;
        public int Zone { get; set; }
        public string? ColorDt { get; set; }
        public long? Status { get; set; }
    }

}
