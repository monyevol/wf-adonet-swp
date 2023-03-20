namespace CollegeParkAutoParts21.Models
{
    internal class AutoPart
    {
        public int     AutoPartId { get; set; }
        public int     PartNumber { get; set; }
        public int     CarYear    { get; set; }
        public string? Make       { get; set; }
        public string? Model      { get; set; }
        public string? Category   { get; set; }
        public string? PartName   { get; set; }
        public string? PartImage  { get; set; }
        public double  UnitPrice  { get; set; }
    }
}
