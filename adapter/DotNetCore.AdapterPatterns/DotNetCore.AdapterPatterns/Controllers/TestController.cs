using System.Collections.Generic;
using System.Linq;
using DotNetCore.AdapterPatterns.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.AdapterPatterns.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IEnumerable<ToolbarButton> _toolbarButtons;

        public TestController(IEnumerable<ToolbarButton> toolbarButtons)
        {
            _toolbarButtons = toolbarButtons;
        }

        [Route("open")]
        public string GetOpenCommand()
        {
            ToolbarButton button = _toolbarButtons.Where(q => q.CommandName == "Open").FirstOrDefault();

            return button.Click();
        }

        [Route("save")]
        public string GetSaveCommand()
        {
            ToolbarButton button = _toolbarButtons.Where(q => q.CommandName == "Save").FirstOrDefault();

            return button.Click();
        }
    }
}
