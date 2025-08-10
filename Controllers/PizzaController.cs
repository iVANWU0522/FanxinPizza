using FanxinPizza.Models;
using FanxinPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace FanxinPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<IEnumerable<Pizza>> GetAll()
    {
        var pizzas = PizzaService.GetAll();
        return Ok(pizzas);
    }

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        var pizza = PizzaService.GetById(id);
        if (pizza is null) return NotFound();
        return Ok(pizza);
    }

    // POST action
    [HttpPost]
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(GetById), new { id = pizza.Id }, pizza);
    }

    // PUT action
    [HttpPut("{id}")]
    public ActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id) return BadRequest();
        PizzaService.Update(pizza);
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        PizzaService.Delete(id);
        return NoContent();
    }
}