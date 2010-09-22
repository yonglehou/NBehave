using System.Text.RegularExpressions;

namespace NBehave.Narrator.Framework
{
    public class ThenAttribute : ActionStepAttribute
    {
        public ThenAttribute()
        {
            Type = "Then";
        }

        private ThenAttribute(Regex actionMatch)
            : base(actionMatch)
        {
            Type = "Then";
        }

        public ThenAttribute(string regexOrTokenString)
            : base(regexOrTokenString)
        {
            Type = "Then";            
        }
    }
}