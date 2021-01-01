namespace Your2020.Service.TautulliClient
{
    public class TautulliTokenResponse
    {
        public string Status { get; set; } = "";
        public string Token { get; set; } = "";
        public string UUID { get; set; } = "";

        public override string ToString()
        {
            return $"Status = {Status}\n" +
                $"Token = {Token}\n" +
                $"UUID = {UUID}";
        }
    }
}
