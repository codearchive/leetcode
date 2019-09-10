namespace Defanging_IP_Address
{
    public static class Solution
    {
        public static string DefangIPaddr(string address)
        {
            string[] addressParts = address.Split('.');
            string str = addressParts[0] + "[.]" + addressParts[1] + "[.]" + addressParts[2] + "[.]" + addressParts[3];
            return str;
        }
    }
}
