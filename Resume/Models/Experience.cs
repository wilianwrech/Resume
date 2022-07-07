namespace Resume.Models;

public record Experience(
    string Institution,
    string? Duration,
    DateOnly IniDate,
    DateOnly? FinDate,
    string Subject,
    string Description,
    string Location,
    string? RefLinkLabel,
    string? RefLink
);