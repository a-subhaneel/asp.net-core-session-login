﻿// <auto-generated />
using DataContextLayer.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataContextLayer.Migrations
{
    [DbContext(typeof(EFDataContext))]
    [Migration("20181013123541_migrate1")]
    partial class migrate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataContextLayer.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentCode");

                    b.Property<string>("DepartmentName");

                    b.Property<string>("Description");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department","dbo");
                });

            modelBuilder.Entity("DataContextLayer.Models.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("DesignationCode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("DesignationId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Designation","dbo");
                });

            modelBuilder.Entity("DataContextLayer.Models.Designation", b =>
                {
                    b.HasOne("DataContextLayer.Models.Department", "DepartmentInfo")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
