using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallViewerData.Models
{
    [Table("Incident", Schema = "Fact")]
    public class Incident
    {
        [Column ("Incident Key") ]
        public Guid IncidentKey { get; set; }

        [Column("Incident ID")]
        public int IncidentID { get; set; }
      

    }
}
