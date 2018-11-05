using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BoardChitless.Shared.DataContracts
{
    public class players : DataContractTableBase
    {

        [DataMember]
        [Required]
        public Guid playerID { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string emailAddress { get; set; }

        [DataMember]
        public string externalID { get; set; }

    }
}




        