using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MySkill
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
        public string Skill1 { get; set; }
        [StringLength(50)]
        public string Skill2 { get; set; }
        [StringLength(50)]
        public string Skill3 { get; set; }
        [StringLength(50)]
        public string Skill4 { get; set; }
        [StringLength(400)]
        public string Images { get; set; }
    }
}
