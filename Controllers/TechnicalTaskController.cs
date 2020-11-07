using System;
using Microsoft.AspNetCore.Mvc;
using IDT.Data;

namespace IDT.Controllers
{
    public class TechStack
    {
        public string[] techStack { get; set; }
    }
    public class TechnicalTaskController : Controller
    {
        private readonly ApplicationContext _context;
        public TechnicalTaskController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("generateTask")]
        public ActionResult GenerateTask([FromBody] TechStack model)
        {
            Random rnd = new Random();
            string template = _context.Templates.Find(rnd.Next(1, 3)).Template;
            string addition = _context.Additions.Find(rnd.Next(1, 20)).Addition;
            string action = _context.Actions.Find(rnd.Next(1, 20)).Action;
            string actor = _context.Actors.Find(rnd.Next(1, 20)).Actor;
            template = template.Replace("{techStack}", string.Join(", ", model.techStack));
            template = template.Replace("{actor}", actor);
            template = template.Replace("{action}", action);
            template = template.Replace("{addition}", addition);
            return Ok(template);
        }
    }
}