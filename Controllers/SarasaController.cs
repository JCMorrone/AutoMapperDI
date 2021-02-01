using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDI.Controllers
{
    [Route("[controller]")]
    public class SarasaController : Controller
    {
        private readonly IMapper _mapper;
        public SarasaController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult DameSarasa()
        {
            var sarasa = new Sarasa();
            var sarasaVm = _mapper.Map<SarasaVM>(sarasa);
            return Ok(sarasaVm);
        }
    }
}
