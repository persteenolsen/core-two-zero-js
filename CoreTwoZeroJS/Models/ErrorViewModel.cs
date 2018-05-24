using System;

namespace CoreTwoZeroJS.Models
{


    // This "Default" Model are handling Errows by get and set metods
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}