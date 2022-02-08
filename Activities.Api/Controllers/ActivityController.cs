using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Activities.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> Get([FromQuery] ActivityRequest request)
        {
            using (var reader = new StreamReader(@"C:\mycode\github\parsjoberg\Activities\Data\Activities.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Activity>()
                    .OrderByDescending(a => a.Datum)
                    .Skip((request.PageNumber - 1) * request.PageSize)
                    .Take(request.PageSize)
                    .ToList();

                return Ok(records);
            }

            
        }
    }
}
