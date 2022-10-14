using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Models
{
    public class Pokemon : Entity
    {
        public String Name { get; set; }
        public int NationalNumber { get; set; }

        [ForeignKey("Type1Id")]
        public Type Type1 { get; set; }
        [ForeignKey("Type2Id")]
        public Type? Type2 { get; set; }

        public Guid Type1Id { get; set; }
        public Guid? Type2Id { get; set; }

    }
}
