using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public string Contents { get; set; }

        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }

        public virtual Album Album { get; set; }
    }

}