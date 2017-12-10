﻿using System;
using System.Net;
using System.Text;
using YaR.MailRuCloud.Api.Base.Requests.Repo;

namespace YaR.MailRuCloud.Api.Base.Requests.Web
{
    class SecondStepAuthRequest : BaseRequestString
    {
        private readonly string _csrf;
        private readonly string _authCode;

        public SecondStepAuthRequest(IWebProxy proxy, string csrf, string authCode) : base(proxy, null)
        {
            _csrf = csrf;
            _authCode = authCode;
        }

        protected override string RelationalUri => $"{ConstSettings.AuthDomain}/cgi-bin/secstep";

        protected override byte[] CreateHttpContent()
        {
            string data = $"csrf={_csrf}&Login={Uri.EscapeUriString(Auth.Login)}&AuthCode={_authCode}";

            return Encoding.UTF8.GetBytes(data);
        }
    }
}


