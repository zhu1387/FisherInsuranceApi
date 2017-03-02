using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/quotes")]
public class QuotesController : Controller
{ 

    public QuotesController()
    {
   
    }

    [HttpGet]
    public IActionResult GetQuotes()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] Quote quote)
    {
        
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Quote quote)
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete([FromBody] int id)
    {
       
        return Ok();
    }
}