using SlackConnector.Models;
using System.Collections.Generic;

namespace Noobot.Core.MessagingPipeline.Response
{
    public class Attachment
    {
        public Attachment()
        {
            AttachmentFields = new List<AttachmentField>();
            AttachmentActions = new List<AttachmentAction>();
        }

        public string Text { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Fallback { get; set; }

        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }

        public string Color { get; set; }

        public List<AttachmentField> AttachmentFields { get; set; }
        public List<AttachmentAction> AttachmentActions { get; set; }
        public string Pretext { get; set; }
        public string AuthorLink { get; set; }
        public string AuthorIcon { get; set; }
        public string TitleLink { get; set; }

        public Attachment AddAttachmentField(string title, string value)
        {
            return AddAttachmentField(title, value, false);
        }

        public Attachment AddAttachmentField(string title, string value, bool isShort)
        {
            AttachmentFields.Add(new AttachmentField
            {
                Title = title,
                Value = value,
                IsShort = isShort
            });

            return this;
        }

        public Attachment AddAttachmentAction(string text, string url, string type = null,  SlackAttachmentActionStyle style = SlackAttachmentActionStyle.Default)
        {
            AttachmentActions.Add(new AttachmentAction
            {
                Type = type ?? "button",
                Text = text,
                Url = url,
                Style = style
            });

            return this;
        }
    }
}