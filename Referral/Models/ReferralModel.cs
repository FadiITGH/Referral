using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Referral.Models
{
    public class ReferralModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "الرجاء ادخال الاسم الكامل على ان لا يتجاوز 40 حرف...")]
        public string EmpFullName { get; set; }


        [Required]
        [ForeignKey ("DeptTable")]
        public int EmpDep { get; set; }


        [Required]
        public DateTime DateFrom { get; set; }

        [Required]
        public DateTime DateTo { get; set; }


        public string? RefNote { get; set; }
        public string? Notes { get; set; }

        [Required]
        public string? RefImagePath { get; set; }

        [Required]
        public DateTime UpdateDate { get; set; } = DateTime.Now;


        public DepModel DeptTable { get; set; }
    }
}
