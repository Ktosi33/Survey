using System;
using Newtonsoft.Json;
using System.ComponentModel;

namespace aprototype.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class AnswerViewModel
    {
        public AnswerViewModel()
        {

        }

        #region properties
        public int ID { get; set; }
        public int SurveyID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        [DefaultValue(0)]
        public int Type { get; set; }
        [DefaultValue(0)]
        public int Flags { get; set; }
        [DefaultValue(0)]
        public int Value { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        #endregion




    }
}
