using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class EditUsuario : PageModel
    {
        private readonly ILogger<EditUsuario> _logger;

        public EditUsuario(ILogger<EditUsuario> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}