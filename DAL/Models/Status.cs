using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultCRUDGRX.DAL.Models
{
    public class Status
    {
        public int Status_ID { get; set; }
        public string Status_Name { get; set; }
        public ToDo? Todo { get; set; }
    }
}
