namespace SimpleMessagingApp.Data.Dto
{
    public class ClientRequest
    {
        public string ServerNickName { get; set; }
        public string UserNickName { get; set; }
        public string IpAdress { get; set; }
        public int Port { get; set; }
        public string Message { get; set; }
    }
}
