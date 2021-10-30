using System;
using githubResponse.Models

namespace api.Controller
{
	[Api Controller]
	[Route("v1/blipjson")]
	
	public class BuscaGithubController
	{
		[HttpGet]
		[Route("")]
		Task<GithubResponser> GetAddressAsync();
	}
}