﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProyectoBCP_API.Service;
using ProyectoBCP_API.Models;
using System.Threading.Tasks;
using log4net;
using ProyectoBCP_API.Models.Request;
using ProyectoBCP_API.Filters;

namespace ProyectoBCP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [IsAuthenticated]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILog log;

        public UserController(IUserService userService)
        {
            this._userService = userService;
            log = LogManager.GetLogger(typeof(UserController));
        }



        [HttpGet]
        public async Task<UserRequest> GetUser([FromQuery] PaginadoRequest PaginadoResponse)
        {
            log.Info("Inicio Get user");
            return await _userService.GetUser(PaginadoResponse);
        }

        [HttpGet]
        [Route("All")]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            log.Info("Inicio Get all user");
            return await _userService.GetAllUser();
        }

        [HttpGet("{id}")]
        public async Task<User> GetUserById(int id)
        {
            log.Info("Inicio Get user By Id");
            return await _userService.GetUserById(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] User user)
        {
            log.Info("Inicio Post user");
            var result = await _userService.InsertUser(user);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] User user)
        {
            log.Info("Inicio Put user ById");
            var result = await _userService.UpdateUser(id, user);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id, [FromBody] User user)
        {
            log.Info("Inicio Delete user ById");
            var result = await _userService.DeleteAsyncByid(id, user);
            return Ok(result);
        }
    }
}