using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.DanLiris.Service.Core.Lib.Models
{
    public class TermOfPayment : StandardEntity, IValidatableObject
    {
        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(1000)]
        public string termOfPayment { get; set; }

        public bool IsExport { get; set; }     

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(this.termOfPayment))
                yield return new ValidationResult("Term of Payment is required", new List<string> { "termOfPayment" });
        }
    }
}
