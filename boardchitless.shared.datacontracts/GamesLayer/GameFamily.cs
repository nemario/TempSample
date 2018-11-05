using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BoardChitless.Shared.DataContracts
{
    public class GameFamily : DataContractTableBase
    {

        [DataMember]
        [Required]
        public long gameFamilyID { get; set; }

        [DataMember]
        [Required]
        public string name { get; set; }

    }
}
