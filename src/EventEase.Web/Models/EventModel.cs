using System.ComponentModel.DataAnnotations;

namespace EventEase.Web.Models;

public class EventModel
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data é obrigatória.")]
    public DateTime Date { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "O local é obrigatório.")]
    public string Location { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}
