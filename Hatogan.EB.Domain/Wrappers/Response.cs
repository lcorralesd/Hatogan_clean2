using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.EB.Domain.Wrappers
{
    public class Response<T>
    {
        public bool Successful { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; } = new();
        public T? Data { get; set; }
        public Response(T data, string message)
        {
            Successful = true;
            Message = message;
            Data = data;
        }

        public Response() { }

        public Response(string message)
        {
            Successful = false;
            Message = message;
        }

    }
}
