﻿// <auto-generated />
using CrudApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudApp.Migrations
{
    [DbContext(typeof(CrudAppContext))]
    partial class CrudAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudApp.Model.Etudiant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("tel")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("Etudiant");
                });
#pragma warning restore 612, 618
        }
    }
}