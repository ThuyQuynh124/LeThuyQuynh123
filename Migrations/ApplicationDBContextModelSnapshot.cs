﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeThuyQuynh123.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LeThuyQuynh123.Models.Company", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("LeThuyQuynh123.Models.LTQ", b =>
                {
                    b.Property<string>("LTQId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LTQGender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LTQName")
                        .HasColumnType("TEXT");

                    b.HasKey("LTQId");

                    b.ToTable("LTQ");
                });
#pragma warning restore 612, 618
        }
    }
}
