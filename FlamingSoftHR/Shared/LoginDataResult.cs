using System;
namespace FlamingSoftHR.Shared
{
    public class LoginDataResult
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
