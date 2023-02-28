using BeautyCenter.Entities;
using BeautyCenter.Service.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace BeautyCenter.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountriesController : ControllerBase
	{

		private readonly IService<Country> _service;

		public CountriesController(IService<Country> service)
		{
			_service = service;
		}

		// GET: api/<CountriesController>
		[HttpGet]
		public IEnumerable<Country> Get()
		{
			return _service.GetAll();
		}

		// GET api/<CountriesController>/5
		[HttpGet("{id}")]
		public Country Get(int id)
		{
			return _service.Find(id);
		}

		// POST api/<CountriesController>
		[HttpPost]
		public Country Post([FromBody] Country value)
		{
			_service.Add(value);
			_service.SaveChanges();
			return value;
		}

		// PUT api/<CountriesController>/5
		[HttpPut("{id}")]
		public ActionResult Put([FromBody] Country value)
		{
			_service.Update(value);
			_service.SaveChanges();
			return NoContent();

		}

		// DELETE api/<CountriesController>/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			var kayit = _service.Find(id);
			if (kayit == null)
			{
				return BadRequest();
			}
			_service.Delete(kayit);
			_service.SaveChanges();
			return StatusCode(StatusCodes.Status200OK);
		}
	}
}