using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	//Implement MailNotification
	internal class MailNotification:INotificationChannel
	{
		public void Send(String message)
		{
			Console.WriteLine($"Sending email with messsage: {message}");
		}
			
	}
}
