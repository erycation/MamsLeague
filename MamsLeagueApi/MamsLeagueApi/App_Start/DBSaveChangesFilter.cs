using MamsLeagueApi.DomainLeague.Persistance;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MamsLeagueApi.App_Start
{
    public class DBSaveChangesFilter : IAsyncActionFilter
    {
        private readonly MamsLeagueDBContext _dbContext;

        public DBSaveChangesFilter(MamsLeagueDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task OnActionExecutionAsync(
            ActionExecutingContext context,
            ActionExecutionDelegate next)
        {

            var result = await next();
            if (context.HttpContext.Request.Method == "POST")
            {
                if (result.Exception == null || result.ExceptionHandled)
                {
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
