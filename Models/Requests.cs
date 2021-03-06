using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable
 
namespace homework9.Models
{
    public partial class Requests
    {
        public Requests()
        {
            Applicants = new HashSet<Applicants>();
        }

        public int Id { get; set; }
        public string WrittenRequest { get; set; }
        public int ProvinceId { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int ApplicantId { get; set; }

        public virtual Applicants Applicant { get; set; }
        public virtual Provinces Province { get; set; }
        public virtual ICollection<Applicants> Applicants { get; set; }
    }
}
