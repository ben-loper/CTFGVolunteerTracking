using Backend.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VolunteerController : ControllerBase
    {
        private readonly ILogger<VolunteerController> _logger;

        public VolunteerController(ILogger<VolunteerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult SaveVolunteerForm(VolunteerSignUp req)
        {
            // Save to DB
            return Ok();
        }
    }
}
