using Dictionary.Properties;
using System.Collections.Generic;

namespace Dicitionary.Models
{
    public class Word
    {
        public static readonly string DefaultImagePath = "./Resources/NoImage.jpg";

        public Word()
        {
            Name = string.Empty;
            Category = string.Empty;
            Description = string.Empty;
            ImagePath = DefaultImagePath;
        }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Word word &&
                   Name == word.Name &&
                   Category == word.Category &&
                   Description == word.Description &&
                   ImagePath == word.ImagePath;
        }
    }
}
