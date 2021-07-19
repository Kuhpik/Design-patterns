namespace Kuhpik.DesignPatterns.Structural.Bridge
{
    public class IOSMessangerImplementation : IMessangerImplementation
    {
        string IMessangerImplementation.Platform => "iOS";

        string IMessangerImplementation.ProcessChatMessage(string message)
        {
            var step1 = RemoveVerbalAbuse(message);
            var step2 = HighlightDatetime(step1);

            return step2;
        }

        void IMessangerImplementation.RenderBackButton()
        {
            //Skip cause everyone using gestures by guideline
        }

        void IMessangerImplementation.RenderChatView()
        {
            //Do some magic
            //Maybe use some swift-specific libraries
        }

        string RemoveVerbalAbuse(string message)
        {
            string result = message;

            //Looking for verbal abuse
            //...

            result = result.Replace("af", ""); //Dummy

            return result;
        }

        string HighlightDatetime(string message)
        {
            string result = message;

            //Looking for date-time words like 'Today'
            //...

            result = result.Replace("Today", "<color=cyan>Today</color>"); //Dummy

            return result;
        }
    }
}
