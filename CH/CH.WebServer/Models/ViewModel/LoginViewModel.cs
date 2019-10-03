using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CH.WebServer.Models.ViewModel
{
    public class LoginViewModel
    {
        /// <summary>
        /// UserId
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// DelFlag
        /// </summary>
        public string DelFlag { get; set; }
    }
}