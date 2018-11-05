using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace BoardChitless.Shared.DataContracts
{
    public class rawStorage : DataContractTableBase
    {

        [DataMember]
        [Required]
        public long rawStorageID { get; set; }

        [DataMember]
        [Required]
        public string TheBlob { get; set; }

        [DataMember]
        public string externalID { get; set; }

        //[DataMember]
        //[Required]
        ////0 inactive 1 active
        //public long status { get; set; }

    }
}
