using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace AdminCRUD.Model
{
    public class Tintuc
    {
        [Key]
        public int Id_News { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
      
        public string Title { get; set; }   
    }
}
