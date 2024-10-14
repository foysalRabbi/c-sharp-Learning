using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class SMSNotification : INotificationChannel
	{
		public void Send(string message)
		{
			Console.WriteLine($"Sending SMS with messsage: {message}");
		}
	
	}


}

