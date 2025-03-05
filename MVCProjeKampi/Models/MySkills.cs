namespace MVCProjeKampi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MySkills
    {
        [Key]
        public int SkillID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(25)]
        public string Surname { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Skills { get; set; }

        [StringLength(400)]
        public string Images { get; set; }
    }
}
