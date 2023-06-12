// API Controller for a Chat Bot Interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Company.Models;
using Company.Data;
using Company.Services;

namespace Company.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyBotController : ControllerBase
    {
        private readonly ILogger<CompanyBotController> _logger;
        private readonly CompanyDBContext _context;

        private readonly ISKService _skService;

        public CompanyBotController(ILogger<CompanyBotController> logger, CompanyDBContext context, ISKService skService)
        {
            _logger = logger;
            _context = context;
            _skService = skService;
        }

        [HttpPost("input")]
        public async Task<string> Post([FromBody] APIRequest input)
        {
            return await _skService.GetResponse(input);
        }
    }
}