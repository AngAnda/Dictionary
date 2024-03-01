using System.Collections.Generic;

namespace Dicitionary.Models
{
    public class Word
    {
        public Word()
        {
            Name = string.Empty;
            Category = string.Empty;
            Description = string.Empty;
            ImagePath = string.Empty;
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

        public override int GetHashCode()
        {
            int hashCode = -1379583215;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Category);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImagePath);
            return hashCode;
        }
    }
}
