using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebAPIProject.Models
{
    public class albums
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
    }
}