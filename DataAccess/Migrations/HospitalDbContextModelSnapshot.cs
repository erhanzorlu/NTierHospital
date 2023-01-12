﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entity.Doktor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoliclinicID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PoliclinicID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DataAccess.Entity.Hasta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DataAccess.Entity.Hemsire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoliclinicID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PoliclinicID");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("DataAccess.Entity.Poliklinik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Policlinic");
                });

            modelBuilder.Entity("DataAccess.Entity.Randevu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PoliclinicID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.HasIndex("PoliclinicID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DataAccess.Entity.Doktor", b =>
                {
                    b.HasOne("DataAccess.Entity.Poliklinik", "Policlinic")
                        .WithMany("Doctors")
                        .HasForeignKey("PoliclinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("DataAccess.Entity.Hemsire", b =>
                {
                    b.HasOne("DataAccess.Entity.Poliklinik", "Policlinic")
                        .WithMany("Nurses")
                        .HasForeignKey("PoliclinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("DataAccess.Entity.Randevu", b =>
                {
                    b.HasOne("DataAccess.Entity.Hasta", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entity.Poliklinik", "Policlinic")
                        .WithMany("Appointments")
                        .HasForeignKey("PoliclinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("DataAccess.Entity.Hasta", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DataAccess.Entity.Poliklinik", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });
#pragma warning restore 612, 618
        }
    }
}
