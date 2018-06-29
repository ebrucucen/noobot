using SlackConnector.Models;

namespace Noobot.Core.MessagingPipeline.Response
{
    public class AttachmentAction
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public SlackAttachmentActionStyle Style { get; set; }
    }
}