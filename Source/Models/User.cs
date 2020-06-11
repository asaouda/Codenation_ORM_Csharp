using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("user")]
    public class User
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("full_name", TypeName = "varchar(100)"),Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Column("email", TypeName = "varchar(100)"),Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("nickname", TypeName = "varchar(50)"),Required]
        [MaxLength(50)]
        public string NickName { get; set; }

        [Column("password", TypeName = "varchar(255)"),Required]
        [MaxLength(255)]
        public string PassWord { get; set; }

        [Column("created_at", TypeName = "timestamp"),Required]
        public DateTime CreatedAt { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
