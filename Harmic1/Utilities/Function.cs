using Microsoft.AspNetCore.Mvc;

namespace Harmic1.Utilities
{
    public class Function 
    {
        public static string TitleSlugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}
