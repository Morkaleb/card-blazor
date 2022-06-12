﻿// <auto-generated />
using BlazorE_Comnerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorE_Comnerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220612174851_productSeeding")]
    partial class productSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorE_Comnerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Elf Wizard",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=f8b87807-cac5-4e33-a8ed-a9ced0cd83a1",
                            Price = 0.5m,
                            Title = "Rumor Gatherer"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Kamigawa: Neon Dynasty",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=9033cf27-d9e6-49b8-8ee1-c1f38c9680b9",
                            Price = 7.46m,
                            Title = "Junji, the Midnight Sky"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=31b770cc-09e7-4c0b-b2a4-462ab4f7200d",
                            Price = 7.74m,
                            Title = "Expressive Iteration"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Streets of New Capenna",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=ba4fa4c8-f09f-4d97-a7d1-1b93caf7d4f9",
                            Price = 4.45m,
                            Title = "Ziatora, the Incinerator"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Kamigawa: Neon Dynasty",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=a548dcd-c1dd-492d-a69f-c65dfeef0633",
                            Price = 3.01m,
                            Title = "Sokenzan, Crucible of Defiance"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Modern Horizons 2 ",
                            ImageUrl = "https://www.demonictrader.ca/marketapi/cardGetter/get-card-image/?imageId=676758ee-dac8-4c97-8a62-fff25bcbb6df",
                            Price = 32.65m,
                            Title = "Esper Sentinel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
