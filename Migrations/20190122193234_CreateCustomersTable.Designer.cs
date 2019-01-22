﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace demoproj.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190122193234_CreateCustomersTable")]
    partial class CreateCustomersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("phone");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasData(
                        new { id = 1, email = "j.galt@gmail.com", name = "John Galt", phone = "800-444-5555" },
                        new { id = 2, email = "dagny.taggart@taggartrail.com", name = "Dagny Taggart", phone = "888-555-4444" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}