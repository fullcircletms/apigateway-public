namespace FullCircleTMS.ApiGateway.Models.Authentication
{
    public class AuthenticateRequest
    {
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
    }
}