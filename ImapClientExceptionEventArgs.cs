using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AE.Net.Mail {
	public class ImapClientExceptionEventArgs : EventArgs
    {
		public ImapClientExceptionEventArgs(Exception Exception) {
			this.Exception = Exception;
		}

		public Exception Exception { get; set; }
	}
}
