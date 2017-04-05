using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

[Route("api/[controller]")]
public class ConfigurationController : ControllerBase
{
	private Data data;
	public ConfigurationController(IOptions<Data> options)
	{
		data = options.Value;
	}

    [HttpGet]
    [Route("")]
    public IActionResult Get()
    {
        return Ok(data.ConnectionString);
    }
}