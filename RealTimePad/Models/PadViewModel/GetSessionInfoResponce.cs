namespace RealTimePad.Models.PadViewModels
{
    public class GetSessionInfoResponce
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public SessionInfoData Data { get; set; }
    }
}