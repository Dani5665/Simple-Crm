﻿using System.Security.Claims;

namespace AutoPlusCrm.Extensions
{
	public static class ClaimsPrincipalExtensions
	{
		public static string Id(this ClaimsPrincipal user)
		{
			return user.FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}
