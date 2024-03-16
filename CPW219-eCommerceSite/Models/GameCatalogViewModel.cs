namespace CPW219_eCommerceSite.Models
{
    public class GameCatalogViewModel
    {
        public GameCatalogViewModel(List<Games> game, int lastPage, int currPage) 
        {
            Games = game;
            LastPage = lastPage;
            CurrentPage = currPage;
        }

        public List<Games> Games { get; set; } 

        /// <summary>
        /// The last page of the catalog. Calculated by having a total number of products divided by products per page.
        /// </summary>
        public int LastPage { get; set; }

        /// <summary>
        /// The current page the user is viewing
        /// </summary>
        public int CurrentPage { get; set; }
    }
}
