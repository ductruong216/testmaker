using System;
using Newtonsoft.Json;

namespace TestMaker.ViewModels
{
    public class BaseViewModel
    {
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}