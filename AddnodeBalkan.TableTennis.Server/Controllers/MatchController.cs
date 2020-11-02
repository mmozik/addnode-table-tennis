using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddnodeBalkan.TableTennis.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddnodeBalkan.TableTennis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService matchservice)
        {
            matchService = matchservice;
        }


    }
}