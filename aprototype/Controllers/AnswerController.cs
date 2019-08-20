using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using aprototype.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aprototype.Controllers
{
    [Route("api/[controller]")]
    public class AnswerController : Controller
    {

        [HttpGet("All/{questionID}")]
        public IActionResult All(int questionID)
        {
            var sampleAnswers = new List<AnswerViewModel>();

            sampleAnswers.Add(new AnswerViewModel()
            {
                ID = 1,
                QuestionID = questionID,
                Text = "Przyjaciol i rodzine",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i <= 5; i++)
            {

                sampleAnswers.Add(new AnswerViewModel()
                {
                    ID = i,
                    QuestionID = questionID,
                    Text = String.Format("Przykładowe odpowiedz {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }
            return new JsonResult(
                sampleAnswers,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Content("(Jeszcze) niezaimplementowane!");
        }
        [HttpPut]
        public IActionResult Put(AnswerViewModel model)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public IActionResult Post(AnswerViewModel model)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
