using Application.Services.Abstraction;
using Application.Services.Implementation;
using Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Managment_System.Server.Controllers
{
    /// <summary>
    /// Manages tasks within the system. Accessible by Manager and Admin roles.
    /// </summary>
    [Authorize(Roles = "Manager,Admin")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskManagementService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskController"/> class.
        /// </summary>
        /// <param name="service">The task management service.</param>
        public TaskController(ITaskManagementService service)
        {
            this._service = service;
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="task">Details of the task to create.</param>
        /// <returns>The result of the task creation operation.</returns>
        [HttpPost("Create task")]
        public async Task<IActionResult> CreateTask([FromBody] TaskWrite task)
        {
            var result = await _service.Create(task);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves all tasks.
        /// </summary>
        /// <returns>A list of all tasks.</returns>
        [HttpGet("Get all tasks")]
        public async Task<IActionResult> GetAllTasks()
        {
            var allTasks = await _service.GetAll();
            return Ok(allTasks);
        }

        /// <summary>
        /// Deletes a task by its ID.
        /// </summary>
        /// <param name="Id">The ID of the task to delete.</param>
        /// <returns>The result of the task deletion operation.</returns>
        [HttpDelete("Delete task")]
        public async Task<IActionResult> DeleteTask(string Id)
        {
            var result = await _service.Detelete(Id);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves a task by its ID.
        /// </summary>
        /// <param name="taskId">The ID of the task to retrieve.</param>
        /// <returns>The details of the task.</returns>
        [HttpGet("Get Task By Id")]
        public async Task<IActionResult> GetTaskById(string taskId)
        {
            var result = await _service.GetById(taskId);
            return Ok(result);
        }

        /// <summary>
        /// Searches for tasks based on specified parameters.
        /// </summary>
        /// <param name="detailedSearchParametrs">The search parameters.</param>
        /// <returns>A list of tasks that match the search criteria.</returns>
        [HttpGet("Search Task")]
        public async Task<IActionResult> GetTaskById(DetailedSearchParametrs detailedSearchParametrs)
        {
            var result = await _service.Search(detailedSearchParametrs);
            return Ok(result);
        }

        /// <summary>
        /// Updates a task's details.
        /// </summary>
        /// <param name="task">The new details for the task.</param>
        /// <returns>The result of the task update operation.</returns>
        [HttpPost("Update Task")]
        public async Task<IActionResult> UpdateTask([FromBody] TaskRead task)
        {
            var result = await _service.Update(task);
            return Ok(result);
        }
    }

}
