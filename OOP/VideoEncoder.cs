using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	// VideoEncoder Class with Dependency Injection
	internal class VideoEncoder
	{
		

		private readonly IList<INotificationChannel> _notificationChannels;
		
        public VideoEncoder(IList<INotificationChannel> notificationChannels)
		{
			_notificationChannels = notificationChannels;
		}

		public void Encode()
		{
			foreach (var channel in _notificationChannels)
			{
				channel.Send("Video has been ecoded");
			}
		}			




	}
}
