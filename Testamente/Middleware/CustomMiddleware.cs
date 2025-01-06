namespace Testamente.Middleware
{
	public class CustomMiddleware
	{
		private readonly RequestDelegate _next;

		public CustomMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			context.Response.OnStarting(() =>
			{
				context.Response.Headers.Add("X-Cusom-Header", "ExamTask");
				return Task.CompletedTask;
			});

			await _next(context);
		}

	}
}
