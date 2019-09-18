using System;
using Newtonsoft.Json;
using System.ComponentModel;


namespace aprototype.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]

    public class SurveyViewModel
    {
        public SurveyViewModel()
        {

        }

        #region properties
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        [DefaultValue(0)]
        public int Type { get; set; }
        [DefaultValue(0)]
        public int Flags { get; set; }
        public string UserID { get; set; }
        [JsonIgnore]
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        #endregion

    }
}
