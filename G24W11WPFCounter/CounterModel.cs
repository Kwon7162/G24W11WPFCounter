using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G24W11WPFCounter;

class CounterModel
{
	private int _count = 0;

	public int Count
	{
		get => _count;
		set { if(value >= 0) _count = value; }
	}

}
