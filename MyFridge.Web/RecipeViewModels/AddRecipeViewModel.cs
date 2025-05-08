namespace MyFridge.Web.RecipeViewModels
{
     public class AddRecipeViewModel
    {
        public string Name { get; set; }

        public string Duration { get; set; }

        public List<string> Products { get; set; }

        public string Description { get; set; }
    }
}
