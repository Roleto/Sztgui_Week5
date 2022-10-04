using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Clases
{
    public class Message
    {
		private string content;
		private DateTime date;
		private string senderName;
		public Message()
		{

		}

		public Message(string content, DateTime date, string senderName):this()
		{
			this.content = content;
			this.date = date;
			this.senderName = senderName;
		}

		public string Content
		{
			get { return content; }
			set { content = value; }
		}

		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public string  SenderName
		{
			get { return senderName; }
			set { senderName = value; }
		}

		public override string ToString()
		{
			return $"{this.senderName} külde {this.date}-kor";
		}
	}
}
