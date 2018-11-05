using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BoardChitless.Shared.DataContracts
{
    public class RawGame : DataContractTableBase
    {

        [DataMember]
        [Required]
        public long ID { get; set; }

        [DataMember]
        [Required]
        public string APIID { get; set; }

        [DataMember]
       // [Required]
        public string Name { get; set; }

        [DataMember]
        // [Required]
        public string RecordType { get; set; }

        [DataMember]
        // [Required]
        public int isAlsoExpansion { get; set; }

        [DataMember]
       // [Required]
        public int YearPublished { get; set; }

        [DataMember]
       // [Required]
        public string TheBlob { get; set; }

        [DataMember]
        public int isProcessed { get; set; }

     
    }
}
