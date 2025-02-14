namespace MyFridge.Web.RecipeViewModels
{
     public class RecipeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public IEnumerable<string> RequiredProducts { get; set; } = new List<string>();
    }
}
