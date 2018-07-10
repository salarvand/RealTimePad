namespace RealTimePad.Models.PadViewModels
{
    public class GetRevisionChangesetRequest
    {
        public string Apikey { get; set; }
        public string Rev { get; set; }
        public string PadId { get; set; }
    }
}