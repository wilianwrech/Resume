using System;

namespace Resume.Models
{
    public class Skill
    {
        public Skill() { }

        public Skill(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public Skill(string name, int score, Tag[] tags) : this(name, score) => Tags = tags;

        public string Name { get; set; }
        private int _score;
        public int Score { get => _score; set => _score = value > 5 ? 5 : value < 0 ? 0 : value; }
        public Tag[] Tags { get; set; } = Array.Empty<Tag>();
    }
}