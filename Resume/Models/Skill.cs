namespace Resume.Models;

public record Skill(string Name, int Score, Tag[] Tags)
{
    public Skill(string name, int score) : this(name, score, Array.Empty<Tag>()) { }
    
    public int Score { get; } = Score > 5 ? 5 : Score < 0 ? 0 : Score;
}