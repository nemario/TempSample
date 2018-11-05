using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BoardChitless.Shared.DataContracts
{
    [DataContract]
    public abstract class DataContractTableBase
    {
        //[DataMember]
        //[Required]
        //public long Id { get; set; }

        [DataMember]
        public String addedBy { get; set; }

        [DataMember]
        public DateTime dateAdded { get; set; }

        [DataMember]
        public DateTime dateLastUpdated { get; set; }

        [DataMember]
        public int isActive { get; set; }

        [DataMember]
        public String lastUpdatedBy { get; set; }


    }
}
