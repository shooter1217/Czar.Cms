using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Models
{
    public class Content
    {
        public int Id { set; get; }

        public string title { set; get; }

        public string content { set; get; }

        public int status { set; get; }

        public DateTime add_time { set; get; }

        public DateTime modify_time { set; get; }

    }
}
