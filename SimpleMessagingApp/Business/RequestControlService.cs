using SimpleMessagingApp.Data.Dto;
using System.Text;

namespace SimpleMessagingApp.Business
{
    public static class RequestControlService
    {
        public static bool ControlData(ClientRequest clientRequest)
        {
            StringBuilder errorList = new();
            if (string.IsNullOrWhiteSpace(clientRequest.IpAdress))
            {
                errorList.AppendLine("Ip adres can not be null");
            }
            if (string.IsNullOrWhiteSpace(clientRequest.ServerNickName))
            {
                errorList.AppendLine("Nick name can not be null");
            }
            if ((clientRequest?.Port ?? 0) == 0)
            {
                errorList.AppendLine("Port number can not be null");
            }
            if (errorList.Length > 0)
            {
                errorList.AppendLine("Fix the specified validation errors");
                MessageBox.Show(errorList.ToString(), "Null Reference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
