﻿using APISoftplan;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace WebAPI.TestesUnitarios.Fixtures
{
    public class ShowpathcodesContext
    {
        public HttpClient Client { get; set; }

        private TestServer _server;

        public ShowpathcodesContext()
        {
            SetupClient();
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = _server.CreateClient();

        }
    }
}
