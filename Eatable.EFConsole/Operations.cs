using Eatable.Data.General;

namespace Eatable.EFConsole
{
    public class Operations
    {
        public void Import(List<Translation> translations)
        {
            using (var context = new EatableContext())
            {
                //context.Translations.AddRangeAsync(translations);
                //context.SaveChanges();
            }
          
        }
    }
}
