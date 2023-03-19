using System.Collections.Generic;

namespace CRM_QLQHKH.Models
{
    public class Mail
    {
        public string Subject { get; set; }
        public string DestMail { get; set; }
        public string Content { get; set; }
        //public List<MailAttachment> Attachments { get; set; }
    }
    //public class MailAttachment
    //{
    //    public byte[] Stream { get; set; }
    //    public string ContentType { get; set; }
    //}
}
