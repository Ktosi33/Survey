using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aprototype.ViewModels;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aprototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {

        [HttpGet("All/{surveyID}")]
        public IActionResult All(int surveyID)
        {
            var sampleResult = new List<ResultViewModel>();

            sampleResult.Add(new ResultViewModel()
            {
                ID = 1,
                SurveyID = surveyID,
                Text = "Co cenisz najbardziej?",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i <= 5; i++)
            {

                sampleResult.Add(new ResultViewModel()
                {
                    ID = i,
                    SurveyID = surveyID,
                    Text = String.Format("Przykładowe pytanie {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }
            return new JsonResult(
                sampleResult,
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
