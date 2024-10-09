using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_View.People.Controls.Events
{
	public class OnPersonSelectedEventArgs:EventArgs
	{
		public int PersonId { get; set; }
		public OnPersonSelectedEventArgs(int personId)
		{
			this.PersonId = personId;
		}
	}
}
