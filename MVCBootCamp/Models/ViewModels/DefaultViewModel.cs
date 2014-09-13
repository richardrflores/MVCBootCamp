using System.Collections.Generic;

namespace MVCBootCamp.Models.ViewModels
{
    public class DefaultViewModel
    {
        public Target Target { get; set; }
        public FeedBack FeedBack { get; set; }

        public IEnumerable<Target> Targets { get; set; }
    }
}