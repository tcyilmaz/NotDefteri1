using System.ComponentModel.DataAnnotations.Schema;

namespace NotDefteri1.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string noteTitle { get; set; }
        public string noteDescription { get; set; }
        public DateTime noteDate { get; set; }
        public Note()
        {
            this.noteDate = DateTime.UtcNow;
        }
    }
}
