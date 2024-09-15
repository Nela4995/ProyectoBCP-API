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
    public class SubMenuController : ControllerBase
    {
        private readonly ISubMenuService _subMenuService;
        private readonly ILog log;

        public SubMenuController(ISubMenuService subMenuService)
        {
            this._subMenuService = subMenuService;
            log = LogManager.GetLogger(typeof(UserController));
        }
        [HttpGet]
        public async Task<SubMenuRequest> GetUser([FromQuery] PaginadoRequest PaginadoResponse)
        {
            log.Info("Inicio Get SubMenu");
            return await _subMenuService.GetSubMenu(PaginadoResponse);
        }

        [HttpGet]
        [Route("All")]
        public async Task<IEnumerable<SubMenu>> GetAllSubMenu()
        {
            log.Info("Inicio Get all submenu");
            return await _subMenuService.GetAllSubMenu();
        }
        [HttpGet("{id}")]
        public async Task<SubMenu> GetSubMenuById(int id)
        {
            log.Info("Inicio Get submenu By Id");
            return await _subMenuService.GetSubMenuById(id);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SubMenu subMenu)
        {
            log.Info("Inicio Post subMenu");
            var result = await _subMenuService.InsertSubMenu(subMenu);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SubMenu subMenu)
        {
            log.Info("Inicio Put submenu ById");
            var result = await _subMenuService.UpdateSubMenu(id, subMenu);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id, [FromBody] SubMenu subMenu)
        {
            log.Info("Inicio Delete submenu ById");
            var result = await _subMenuService.DeleteAsyncByid(id, subMenu);
            return Ok(result);
        }

    }
}
