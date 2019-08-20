using Newtonsoft.Json;
using System.ComponentModel;

namespace TestMaker.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class ResultViewModel : BaseViewModel
    {
        public ResultViewModel()
        {
        }

        public int QuizId { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(0)]
        public int Flags { get; set; }

        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
    }
}