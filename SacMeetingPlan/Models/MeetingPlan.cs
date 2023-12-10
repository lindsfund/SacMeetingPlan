using System.ComponentModel.DataAnnotations;

namespace SacMeetingPlan.Models
{
    public class MeetingPlan
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Meeting Date")]
        [DataType(DataType.DateTime)]
        public DateTime MeetingDate { get; set; }

        [StringLength(50)]
        [Display(Name = "Conducting")]
        public string? ConductingLeader { get; set; }

        [StringLength(50)]
        [Display(Name = "Presiding")]
        public string? PresidingLeader { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Opening Hymn (Title - number)")]
        public string? OpeningHymn { get; set; }

        [StringLength(50)]
        [Display(Name = "Opening Prayer")]
        public string? OpeningPrayer { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Sacrament Hymn (Title - number)")]
        public string? SacramentHymn { get; set; }

        [StringLength(100)]
        public ICollection<SpeakerTopic>? Speakers { get; set; } 
            

        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Musical Number (optional)")]
        public string? MusicalNumber { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Closing Hymn (Title - number)")]
        public string? ClosingHymn { get; set; }

        [StringLength(50)]
        [Display(Name = "Closing Prayer")]
        public string? ClosingPrayer { get; set; }
    }
}
