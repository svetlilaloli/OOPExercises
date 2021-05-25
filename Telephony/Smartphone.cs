namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public string Browse(string site)
        {
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
