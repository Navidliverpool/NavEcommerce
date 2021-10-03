﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NavEcommerce.Models.DbContextFolder;

namespace NavEcommerce.Migrations
{
    [DbContext(typeof(NavEcommerceDbContext))]
    [Migration("20211002183045_m2mpayload")]
    partial class m2mpayload
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NavEcommerce.Models.MotorcyclesFolder.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("NavEcommerce.Models.MotorcyclesFolder.BrandMotorcycle", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("MotorcycleId")
                        .HasColumnType("int");

                    b.Property<string>("Dealers")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId", "MotorcycleId");

                    b.HasIndex("MotorcycleId");

                    b.ToTable("BrandMotorcycle");
                });

            modelBuilder.Entity("NavEcommerce.Models.MotorcyclesFolder.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Motorcycles");
                });

            modelBuilder.Entity("NavEcommerce.Models.MotorcyclesFolder.BrandMotorcycle", b =>
                {
                    b.HasOne("NavEcommerce.Models.MotorcyclesFolder.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NavEcommerce.Models.MotorcyclesFolder.Motorcycle", null)
                        .WithMany()
                        .HasForeignKey("MotorcycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
