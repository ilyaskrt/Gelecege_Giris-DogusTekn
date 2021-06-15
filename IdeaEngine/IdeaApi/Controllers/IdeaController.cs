using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public readonly IIdeaRepository _ideaRepository;
    public class IdeaController : ControllerBase
    {
        _ideaRepository = ideaRepository;
    }
    [HttpPost]
    public IActionResault Create([FromBody]Idea idea)
    {
        var inserted = _ideaRepository.Create(idea);
    }
}
