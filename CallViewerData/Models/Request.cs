using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallViewerData.Models
{

    [Table("Request", Schema = "Fact")]
    public class Request
    {
       
      
            [Column("Request Key")]
            public Guid RequestKey { get; set; }

            [Column("Request ID")]
            public int RequestID { get; set; }


    

    }
}
