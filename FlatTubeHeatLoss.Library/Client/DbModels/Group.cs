using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DbModels
{
    public class Group
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
