using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class NewTaskViewModel
    {
        [Required(ErrorMessage = "Task need to have title")]
        public string Title { get; set; }

        public string Desc { get; set; }
    }
}
