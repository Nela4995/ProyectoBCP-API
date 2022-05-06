﻿using ProyectoBCP_API.Models.Request;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoBCP_API.Models
{
    public partial class SubMenu
    {
        public int Id { get; set; }
        public int IdMenu { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public DateTime FecIngreso { get; set; }
        public string UsuarioIngresa { get; set; }
        public DateTime? FecActualiza { get; set; }
        public string UsuarioActualiza { get; set; }
        public int FlgActivo { get; set; }

        public virtual Menu IdMenuNavigation { get; set; }
    }
    public partial class SubMenuRequest : PaginadoTotalRequest
    {
        public List<SubMenu> SubMenus { get; set; }

    }

}