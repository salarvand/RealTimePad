namespace RealTimePad.Models.PadViewModels
{
    public class SetTextRequest
    {
        public string Apikey { get; set; }
        public string PadId { get; set; }
        public string Text { get; set; }
    }
}