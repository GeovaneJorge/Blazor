using BlazorBitcoinApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBitcoinApp.Services
{
	public class IBitcoinService
	{
		Task<List<BitcoinDataDTO>> FindBy(DateTime startDate);
	}
}
