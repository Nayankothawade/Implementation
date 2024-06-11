namespace CookiesmanagementApp.Models
{
    public class Cart
    {
        public string Id { get; set; }

        public List <string> Items { get; set; }

        public Cart()
        {
            this.Items = new List<string>();
        }

    }
}
