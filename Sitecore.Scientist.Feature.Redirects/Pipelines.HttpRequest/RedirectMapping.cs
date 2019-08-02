using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Sitecore.Scientist.Feature.Redirects.Pipelines.HttpRequest
{
	public class RedirectMapping
	{
		private System.Text.RegularExpressions.Regex _regex;

		public bool IsRegex
		{
			get;
			set;
		}

		public string Pattern
		{
			get;
			set;
		}

		public bool PreserveQueryString
		{
			get;
			set;
		}

		public Sitecore.Scientist.Feature.Redirects.Pipelines.HttpRequest.RedirectType RedirectType
		{
			get;
			set;
		}

		public System.Text.RegularExpressions.Regex Regex
		{
			get
			{
				if (!this.IsRegex)
				{
					return null;
				}
				System.Text.RegularExpressions.Regex regex = this._regex;
				if (regex == null)
				{
					System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(this.Pattern, RegexOptions.IgnoreCase);
					System.Text.RegularExpressions.Regex regex2 = regex1;
					this._regex = regex1;
					regex = regex2;
				}
				return regex;
			}
		}

		public string Target
		{
			get;
			set;
		}

		public RedirectMapping()
		{
		}
	}
}