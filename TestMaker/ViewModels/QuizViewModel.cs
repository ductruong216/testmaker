using Newtonsoft.Json;
using System.ComponentModel;

namespace TestMaker.ViewModels
{
    public class QuizViewModel : BaseViewModel
    {
        public QuizViewModel()
        {
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(0)]
        public int Flags { get; set; }

        public string UserId { get; set; }

        [JsonIgnore]
        public int ViewCount { get; set; }
    }
}