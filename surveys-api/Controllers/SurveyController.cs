using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aprototype.ViewModels;
using Newtonsoft.Json;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aprototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        [HttpGet("Latest/{num?}")]
        public IActionResult Latest(int num = 10)
        {
            var sampleSurvive = new List<SurveyViewModel>();

            sampleSurvive.Add(new SurveyViewModel()
            {
                ID = 1,
                Title = "Co wolisz bardziej?",
                Description = "Ankieta przykladowa",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            for (int i = 2; i <= num; i++)
            {

                sampleSurvive.Add(new SurveyViewModel()
                {
                    ID = i,
                    Title = String.Format("Przykladowa ankieta {0}", i),
                    Description = "Ankieta przykladowa zalezna od i",
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }
            return new JsonResult(
                sampleSurvive,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }
            [HttpGet("Random/{num:int?}")]
        public IActionResult Random(int num = 10)
        {
            var sampleSurvive = ((JsonResult)Latest(num)).Value as List<SurveyViewModel>;

            return new JsonResult(
                sampleSurvive.OrderBy(t => Guid.NewGuid()),
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });

        }
        [HttpGet("ByTitle/{num:int?}")]
        public IActionResult ByTitle(int num = 10)
        {
            var sampleSurvive = ((JsonResult)Latest(num)).Value as List<SurveyViewModel>;

            return new JsonResult(
                sampleSurvive.OrderBy(t => t.Title),
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var v = new SurveyViewModel()
            {
                ID = id,
                Title = String.Format("Przykladowa ankieta o id {0}", id),
                Description = "Ankieta przykladowa",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            };
            return new JsonResult(
                v,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
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

