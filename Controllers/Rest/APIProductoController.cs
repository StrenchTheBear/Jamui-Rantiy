using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jamui_Rantiy.Models;
using Jamui_Rantiy.Data;

namespace Jamui_Rantiy.Controllers.Rest
{
   [ApiController]
    [Route("api/editar")]
    public class APIProductoController : ControllerBase
    {
       private readonly ILogger<APIProductoController> _logger;
       private readonly ApplicationDbContext _context;

        public APIProductoController(ILogger<APIProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
    }
