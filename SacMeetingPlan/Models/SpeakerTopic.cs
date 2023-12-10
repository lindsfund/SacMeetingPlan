using System.ComponentModel.DataAnnotations;

namespace SacMeetingPlan.Models
{
    public class SpeakerTopic
    {
        
        public int ID { get; set; }

        [StringLength(50)]
        public string? SpeakerName {  get; set; }

        [StringLength(50)]
        public string? SpeakerSubject { get; set; }

    }
}
