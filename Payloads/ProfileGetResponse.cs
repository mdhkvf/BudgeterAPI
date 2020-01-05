using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Payloads
{
    public class ProfileGetResponse
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
