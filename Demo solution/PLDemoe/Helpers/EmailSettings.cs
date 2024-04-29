using DALDemo.Models;
using System.Net;
using System.Net.Mail;

namespace PLDemoe.Helpers
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{
			var Client = new SmtpClient("smtp.gmail.com", 587);
			Client.EnableSsl = true;
			Client.Credentials = new NetworkCredential("ebrahimshosha66@gmail.com", "igdn ieqg ypzk hfnx");
			Client.Send("ebrahimshosha66@gmail.com", email.To, email.Subject, email.Body);

		}
	}
}
