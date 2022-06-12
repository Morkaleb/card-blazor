namespace BlazorE_Comnerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Rumor Gatherer",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=f8b87807-cac5-4e33-a8ed-a9ced0cd83a1",
                    Description = "Elf Wizard",
                    Price = .5m
                },
                new Product
                {
                    Id = 2,
                    Title = "Junji, the Midnight Sky",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/" +
                    "cardGetter/get-card-image/?imageId=9033cf27-d9e6-49b8-8ee1-c1f38c9680b9",
                    Description = "Kamigawa: Neon Dynasty",
                    Price = 7.46m
                },
                new Product
                {
                    Id = 3,
                    Title = "Expressive Iteration",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/" +
                    "get-card-image/?imageId=31b770cc-09e7-4c0b-b2a4-462ab4f7200d",
                    Description = "",
                    Price = 7.74m
                },
                new Product
                {
                    Id = 4,
                    Title = "Ziatora, the Incinerator",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/" +
                    "get-card-image/?imageId=ba4fa4c8-f09f-4d97-a7d1-1b93caf7d4f9",
                    Description = "Streets of New Capenna",
                    Price = 4.45m
                },
                new Product
                {
                    Id = 5,
                    Title = "Sokenzan, Crucible of Defiance",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter" +
                        "/get-card-image/?imageId=a548dcd-c1dd-492d-a69f-c65dfeef0633",
                    Description = "Kamigawa: Neon Dynasty",
                    Price = 3.01m
                },
                new Product
                {
                    Id = 6,
                    Title = "Esper Sentinel",
                    ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image" +
                    "/?imageId=676758ee-dac8-4c97-8a62-fff25bcbb6df",
                    Description = "Modern Horizons 2 ",
                    Price = 32.65m
                }
            );     
        }
        public DbSet<Product> Products { get; set; }
    }
}
