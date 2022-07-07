namespace Resume.Models;

public record TimelineNode(
    string Name,
    DateTime IniDate,
    DateTime? FinDate,
    string? ImageLink
);