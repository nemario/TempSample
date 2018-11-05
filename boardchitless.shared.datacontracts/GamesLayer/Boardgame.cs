using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BoardChitless.Shared.DataContracts
{
    public class Boardgame : DataContractTableBase
    {

        [DataMember]
        [Required]
        public long BoardGameID { get; set; }

        [DataMember]
        [Required]
        public string Name { get; set; }


    }
}
