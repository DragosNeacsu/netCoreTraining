using Microsoft.AspNetCore.Builder;
using WebApplication1;

namespace Microsoft.AspNetCore.Builder
{
	public static class ProfilerMiddlewareExtensions
    {
		public static IApplicationBuilder useRequestProfiller(this IApplicationBuilder app)
		{
			app.UseMiddleware<ProfilerMiddleware>();

			return app;
		}
    }
}
