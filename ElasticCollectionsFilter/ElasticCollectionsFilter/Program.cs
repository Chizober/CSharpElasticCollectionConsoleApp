namespace ElasticCollectionsFilter
{

    public class Program
    {
        static void Main(string[] args)
        {

            FilterProducts filter = new FilterProducts();

            string[] properties = filter.Filter().Split(',');
            filter .ListProducts(properties);
            
        }
    }
}