namespace Mvc1.ViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? CategoryName { get; set; }
    }
}
