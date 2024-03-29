using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace InterviewLearning.Models
{

    public class Restaunt //: IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid Id { get; set; }
        public string RestauntName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        [IgnoreDataMember]
        public List<Menu> Menu { get; set; }
        public Guid userId { get; set; }
        //[ScriptIgnore]
        [IgnoreDataMember]

        public virtual User user { get; set; }
    
    }
}