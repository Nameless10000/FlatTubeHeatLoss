using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DbModels
{
    public class Material
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Description("A coeff in heat transfer equation")]
        public double A { get; set; }

        [Description("B coeff in heat transfer equation")]
        public double B { get; set; }
        
        [Description("C coeff in heat transfer equation")]
        public double C { get; set; }

        public int GroupID { get; set; }

        [ForeignKey(nameof(GroupID))]
        public Group Group { get; set; }
    }
}
