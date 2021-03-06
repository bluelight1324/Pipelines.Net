﻿using System;
using Pipelines.ExtensionMethods;

namespace Pipelines
{
    public class PipelineMessage
    {
        public static readonly string MessageIsNotSetError = "String representing a message text should be specified.";

        public string Message { get; }
        public MessageType MessageType { get; }

        public PipelineMessage(string message, MessageType messageType)
        {
            if (message.HasNoValue())
            {
                throw new ArgumentException(MessageIsNotSetError, nameof(message));
            }

            Message = message;
            MessageType = messageType;
        }
    }
}