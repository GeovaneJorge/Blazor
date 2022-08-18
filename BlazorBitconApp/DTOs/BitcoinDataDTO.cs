using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBitcoinApp.DTOs
{
	public class BitcoinDataDTO
	{

		public BitcoinDataDTO()
		{
		}

		public BitcoinDataDTO(DateTime day, decimal closeValue)
		{
			Day = day;
			CloseValue = closeValue;
		}

		public DateTime Day { get; set; }

		public decimal CloseValue { get; set; }
	}
}


