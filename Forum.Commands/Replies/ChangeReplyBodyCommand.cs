﻿using System;
using ENode.Commanding;

namespace Forum.Commands.Replies
{
    public class ChangeReplyBodyCommand : Command
    {
        public string Body { get; set; }

        private ChangeReplyBodyCommand() { }
        public ChangeReplyBodyCommand(string id, string body) : base(id)
        {
            Body = body;
        }
    }
}
