using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationPattern.Result
{
    public class NotificationResultDTO
    {
        public NotificationResultDTO(bool sucess, string message, object data)
        {
            Sucess = sucess;
            Message = message;
            Data = data;
        }

        public bool Sucess { get; private set; }

        public string Message { get; private set; }

        public object Data { get; private set; }
    }
}
