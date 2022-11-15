﻿using System.Text.Json;

namespace PizzaDeliveryApp.CustomExceptionMiddleware
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
            // $"Message, {Message}, StatusCode {StatusCode}";
        }
    }
}
