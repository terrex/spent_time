
using System;

namespace spent_time
{


	public class Timer
	{
		private TimeSpan timeSpan;
		private DateTime dateTime;

		public Timer ()
		{
			this.timeSpan = TimeSpan.Zero;
		}

		public void reset()
		{
			this.timeSpan = TimeSpan.Zero;
		}
		
		public void pause()
		{
			this.stop();
		}
		
		public void continuer()
		{
			this.dateTime = DateTime.Now;
		}
		
		public void stop()
		{
			this.timeSpan += DateTime.Now - this.dateTime;
		}
		
		public void start()
		{
			this.timeSpan = TimeSpan.Zero;
			this.dateTime = DateTime.Now;
		}
		
		public String getTime()
		{
			String str = this.timeSpan.ToString();
			return str.Substring(0, str.IndexOf("."));
		}
	}
}
