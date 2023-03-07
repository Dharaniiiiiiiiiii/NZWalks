using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksApp.Models.Domain;
using NZWalksApp.Repositories;

namespace NZWalksApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper Mapper;

        public RegionController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.Mapper = mapper;
        }

        [HttpGet]
        public async Task <IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            //  return DTO region
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(regions =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = regions.Id,
            //        Code= regions.Code,
            //        Name = regions.Name,    
            //        Area=regions.Area,
            //        Lat= regions.Lat,
            //        Long= regions.Long,
            //        Population= regions.Population,
            //    };

            //    regionsDTO.Add(regionDTO);
            //});
          var regionsDTO=  Mapper.Map<List<Models.DTO.Region>>(regions); 
            
            return Ok(regionsDTO); 

        }
       
    }
}
