﻿using YaR.MailRuCloud.Api.Base;

namespace YaR.MailRuCloud.Api
{
    public class CloudSettings
    {
	    public ITwoFaHandler TwoFaHandler { get; set; }
        public string UserAgent { get; set; }

        public Protocol Protocol { get; set; }

        public int CacheListingSec { get; set; } = 30;

	    public int ListDepth
	    {
		    get => CacheListingSec > 0 ? _listDepth : 1;
	        set => _listDepth = value;
	    }
		private int _listDepth = 1;

        public string SpecialCommandPrefix { get; set; } = ">>";
        public string AdditionalSpecialCommandPrefix { get; set; } = ">>";

        public string DefaultVideoQuality { get; set; } = "all";
    }
}