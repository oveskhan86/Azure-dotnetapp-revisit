using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace azure_app_revisit.Pages
{
    public class DeploymentSlot : PageModel
    {
        private readonly ILogger<DeploymentSlot> _logger;

        public DeploymentSlot(ILogger<DeploymentSlot> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}