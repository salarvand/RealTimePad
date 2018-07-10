namespace RealTimePad.Models.PadViewModels
{
    public class CreateGroupPadRequest
    {
        public string Apikey { get; set; }
        public string GroupId { get; set; }
        public string PadName { get; set; }
        public string Text { get; set; }
    }
}