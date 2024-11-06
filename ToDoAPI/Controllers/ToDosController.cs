using Core.Tokens.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDo.Models.Dtos.ToDo.Request;
using ToDo.Service.Abstracts;
using ToDoAPI.Controllers;

namespace ToDoList.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDosController(IToDoService todoService, DecoderService decoderService) : CustomBaseController
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = todoService.GetAllAsync();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateToDoRequest dto)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var result = todoService.AddAsync(dto);
        return Ok(result);
    }

    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = todoService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateToDoRequest dto)
    {
        var result = todoService.UpdateAsync(dto);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] Guid id)
    {
        var result = todoService.RemoveAsync(id);
        return Ok(result);
    }
}