using Microsoft.AspNetCore.Mvc;
using ToDo.Models.Dtos.Category.Request;
using ToDo.Service.Abstracts;



namespace ToDoList.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(ICategoryService _categoryService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _categoryService.GetAllAsync();
        return Ok(result);
    }

    [HttpPost("add")]
    public IActionResult AddAsync([FromBody] CreateCategoryRequest dto, ICategoryService _categoryService)
    {
        var result = _categoryService.AddAsync(dto);
        return Ok(result);
    }

    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var result = _categoryService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = _categoryService.RemoveAsync(id);
        return Ok(result);
    }

    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateCategoryRequest dto)
    {
        var result = _categoryService.UpdateAsync(dto);
        return Ok(result);
    }
}