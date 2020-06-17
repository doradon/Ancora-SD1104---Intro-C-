using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7._4
{
    class Messages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        private bool _isRead;
        public bool isRead
        {
            get { return _isRead; }
            set
            {
                if (value == true | value == false)
                {
                    _isRead = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect reading status of message!");
                }
            }

        }

        public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            this.isRead = false;
        }
    }
}
