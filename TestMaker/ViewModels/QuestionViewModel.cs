using Newtonsoft.Json;
using System.ComponentModel;

namespace TestMaker.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class QuestionViewModel : BaseViewModel
    {
        public QuestionViewModel()
        {
        }

        public int QuizId { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(0)]
        public int Flags { get; set; }
    }
}