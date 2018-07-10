namespace RealTimePad.Models.PadViewModels
{
    public class CreateSessionRequest
    {
        public string Apikey { get; set; }
        public string GroupId { get; set; }
        public string AuthorId { get; set; }
        public string ValidUntil { get; set; }
    }
}