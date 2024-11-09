using Microsoft.AspNetCore.Mvc;
using Task_Project.Dto.Task;
using Task_Project.Service;

namespace Task_Project.Controller;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTaskById(Guid id)
    {
        try
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            return Ok(task);
        }
        catch (KeyNotFoundException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTasks()
    {
        try
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddTask([FromBody] CreateTaskDto task)
    {
        try
        {
            var newTask = await _taskService.CreateTaskAsync(task);
            return Ok(newTask);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}