using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Data;
using EventCatalogAPI.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;
        private readonly IConfiguration _config;
        public CatalogController(CatalogContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items([FromQuery] int pageIndex = 0, [FromQuery] int pageSize = 6)
        {
            var itemsCount = await _context.CatalogItems.LongCountAsync();
            var items = await _context.CatalogItems.OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            items = ChangePictureURL(items);
            return Ok(items);

        }

        private List<CatalogItem> ChangePictureURL(List<CatalogItem> items)
        {
            items.ForEach(c => c.PictureURL = c.PictureURL.Replace("http://externalcatalogbaseurltobereplaced", _config["ExternalCatalogBaseURL"]));
            return items;

        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogTypes()
        {
            var items = await _context.CatalogTypes.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogCategories()
        {
            var items = await _context.CatalogCategories.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]/type/{catalogTypeId}/category/{catalogCategoryId}")]
        public async Task<IActionResult> Items(int? catalogTypeId, int? catalogCategoryId, [FromQuery] int pageIndex = 0, [FromQuery] int pageSize = 6)
        {
            var root = (IQueryable<CatalogItem>)_context.CatalogItems;
            if (catalogTypeId.HasValue)
            {
                root = root.Where(c => c.CatalogTypeID == catalogTypeId);
            }
            if (catalogCategoryId.HasValue)
            {
                root = root.Where(c => c.CatalogCategoryID == catalogCategoryId);
            }

            var itemsCount = await root.LongCountAsync();
            var items = await root.OrderBy(c => c.Name).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            items = ChangePictureURL(items);
            return Ok(items);

        }
    }
}