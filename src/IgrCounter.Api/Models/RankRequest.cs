using System.ComponentModel.DataAnnotations;

namespace IgrCounter.Api.Models;

public record RankRequest()
{
    [Required]
    public IEnumerable<string> Keywords { get; set; } = Array.Empty<string>();

    [Required]
    public string? Url { get; set; }
}
