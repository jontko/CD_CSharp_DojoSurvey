using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class FormInfo
    {
    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    [MinLength(3)]
    public string Location { get; set; }

    [Required]
    [MinLength(3)]
    public string Language { get; set; }

    [MinLength(20)]
    public string Comment { get; set; }
       
    }
}