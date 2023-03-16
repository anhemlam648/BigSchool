using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Build.Framework;
using VuTrungNghia_2011063715.Models;

namespace VuTrungNghia_2011063715.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}