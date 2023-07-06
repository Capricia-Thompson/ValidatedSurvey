#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ValidatedSurvey.Models;
public class User
{
    [Required]
    [MinLength(2, ErrorMessage = "Please enter a name with at least 2 characters.")]
    public string Name { get; set; }
    public string Location { get; set; }
    public string Language { get; set; }
    [MinLength(20, ErrorMessage = "Please elaborate on your comment.")]
    public string? Comment { get; set; }
}