using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestECommerce.Persistence
{
	public class Configuration
	{
		public static string ConnectionString
		{
			get
			{
				ConfigurationManager configurationManager = new ConfigurationManager();
				configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NestECommerce.WebClient"));
				configurationManager.AddJsonFile("appsettings.json");

				return configurationManager.GetConnectionString("MsSql");

			}
		}
	}
}
