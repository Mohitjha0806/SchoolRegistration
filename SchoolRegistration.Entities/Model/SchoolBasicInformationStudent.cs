using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolRegistration.Entities.Model
{
    public class SchoolBasicInformationStudent
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Invalid School UDISE Code")]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "The UDISE Code must be exactly 11 digits.")]
        public string UDISECode { get; set; }

        [Unicode(false)]
        [StringLength(50)]
        public string SchoolNameEnglish { get; set; }

        [Unicode(true)]
        [StringLength(50)]
        public string SchoolNameHindi { get; set; }


        [Range(1980, 2025, ErrorMessage = "Year must be between 1980 and the current year")]
        public int YearOfEstablishment { get; set; }

        public DateOnly Recognition { get; set; }

        [Unicode(false)]
        [StringLength(30)]
        public string SchoolBoard { get; set; }

        public bool IsActive { get; set; }

    }
}
