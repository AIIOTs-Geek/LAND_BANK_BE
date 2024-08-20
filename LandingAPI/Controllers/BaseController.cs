using System.Net;
using Common.Helper;
using Microsoft.AspNetCore.Mvc;
namespace Api.Controllers;

[ApiController]
public class BaseController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Response<T>(APIResponse<T> response)
    {
        return response.IsValidationError switch
        {
            true when response.Status == HttpStatusCode.Unauthorized => Unauthorized(response.Messages),
            true when response.Status == HttpStatusCode.Conflict => Conflict(response.Messages),
            true when response.Status == HttpStatusCode.NotFound => NotFound(response.Messages),
            true when response.Status == HttpStatusCode.BadRequest => BadRequest(response.Messages),
            true when response.Status == HttpStatusCode.InternalServerError => BadRequest(response.Messages),
            _ => Ok(response),
        };
    }
}
