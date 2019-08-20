using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using aprototype.ViewModels;

namespace aprototype.Controllers
{
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        [HttpGet("All/{surveyID}")]
        public IActionResult All(int surveyID)
        {
            var sampleQuestions = new List<QuestionViewModel>();

            sampleQuestions.Add(new QuestionViewModel()
            {
                ID = 1,
                SurveyID = surveyID,
                Text = "Co cenisz najbardziej??",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            }) ;

            for (int i = 2; i <= 5; i++)
            {

                sampleQuestions.Add(new QuestionViewModel()
                {
                    ID = i,
                    SurveyID = surveyID,
                    Text = String.Format("Przykładowe pytanie {0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                }) ;
            }
            return new JsonResult(
                sampleQuestions,
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
