﻿using System;

namespace Paydock_dotnet_sdk.Models
{
	public class VaultItemsResponse : Response
	{
		public Resource resource { get; set; }

		public class Resource
		{
			public string type { get; set; }
			public Data[] data { get; set; }
			public int count { get; set; }
			public int limit { get; set; }
			public int skip { get; set; }
		}

		public class Data
		{
			public DateTime updated_at { get; set; }
			public string vault_token { get; set; }
			public string card_name { get; set; }
			public int expire_month { get; set; }
			public int expire_year { get; set; }
			public string address_line1 { get; set; }
			public string address_city { get; set; }
			public string address_state { get; set; }
			public string address_country { get; set; }
			public string card_number_last4 { get; set; }
			public string card_scheme { get; set; }
			public string email { get; set; }
			public string phone { get; set; }
			public string first_name { get; set; }
			public string last_name { get; set; }
			public string status { get; set; }
			public DateTime created_at { get; set; }
			public string user_id { get; set; }
			public string company_id { get; set; }
			public string _source_ip_address { get; set; }
			public string type { get; set; }
		}
	}
}
