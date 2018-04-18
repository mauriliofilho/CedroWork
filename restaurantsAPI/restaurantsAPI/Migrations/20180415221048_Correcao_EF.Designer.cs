﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using restaurantsAPI.Context;
using System;

namespace restaurantsAPI.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20180415221048_Correcao_EF")]
    partial class Correcao_EF
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("restaurantsAPI.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DishImage");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("DishPrice");

                    b.Property<int?>("RestaurantId");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("restaurantsAPI.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("restaurantsAPI.Models.Dish", b =>
                {
                    b.HasOne("restaurantsAPI.Models.Restaurant", "Restaurant")
                        .WithMany("Dishs")
                        .HasForeignKey("RestaurantId");
                });
#pragma warning restore 612, 618
        }
    }
}
