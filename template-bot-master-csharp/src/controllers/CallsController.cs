using Autofac;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Internals;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Teams;
using Microsoft.Bot.Connector.Teams.Models;
using Microsoft.Teams.TemplateBotCSharp.Dialogs;
using Microsoft.Teams.TemplateBotCSharp.Properties;
using Microsoft.Teams.TemplateBotCSharp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microsoft.Teams.TemplateBotCSharp
{
	public class CallsController : ApiController
	{
		public async Task<HttpResponseMessage> Post()
		{
			string myData = await Request.Content.ReadAsStringAsync();
			var response = Request.CreateResponse(HttpStatusCode.OK);
			return response;
		}
	}
}