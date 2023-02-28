using BeautyCenter.Entities;
using BeautyCenter.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BeautyCenter.WebAPI.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
	public class ListsController : ControllerBase
	{

	private readonly IService<List> _service;

	public ListsController(IService<List> service)
	{
		_service = service;
	}

	// GET: api/<BrandsController>
	[HttpGet]
	public IEnumerable<List> Get()
	{
		return _service.GetAll();
	}

	// GET api/<BrandsController>/5
	[HttpGet("{id}")]
	public List Get(int id)
	{
		return _service.Find(id);
	}

	// POST api/<BrandsController>
	[HttpPost]
	public List Post([FromBody] List value)
	{
		_service.Add(value);
		_service.SaveChanges();
		return value;
	}

	// PUT api/<BrandsController>/5
	[HttpPut("{id}")]
	public ActionResult Put([FromBody] List value)
	{
		_service.Update(value);
		_service.SaveChanges();
		return NoContent();

	}

	// DELETE api/<BrandsController>/5
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