﻿// <auto-generated />
using System;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibraryEngSoft.Migrations
{
    [DbContext(typeof(PrescriptionContext))]
    [Migration("20210602174351_M003")]
    partial class M003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBase.Modules.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrescriptionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PrescriptionID");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("DataBase.Modules.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datebirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DataBase.Modules.Prescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Prescricoes");
                });

            modelBuilder.Entity("DataBase.Modules.TherapySession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("TherapySessions");
                });

            modelBuilder.Entity("DataBase.Modules.Exercise", b =>
                {
                    b.HasBaseType("DataBase.Modules.Item");

                    b.Property<DateTime>("TimeSugestion")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Exercise");
                });

            modelBuilder.Entity("DataBase.Modules.Medicamento", b =>
                {
                    b.HasBaseType("DataBase.Modules.Item");

                    b.Property<double>("dosage")
                        .HasColumnType("float");

                    b.Property<string>("frequency")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medicamento");
                });

            modelBuilder.Entity("DataBase.Modules.Treatment", b =>
                {
                    b.HasBaseType("DataBase.Modules.Item");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<int>("SessionID")
                        .HasColumnType("int");

                    b.HasIndex("SessionID");

                    b.HasDiscriminator().HasValue("Treatment");
                });

            modelBuilder.Entity("DataBase.Modules.Client", b =>
                {
                    b.HasBaseType("DataBase.Modules.Person");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("DataBase.Modules.Doctor", b =>
                {
                    b.HasBaseType("DataBase.Modules.Person");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("DataBase.Modules.Item", b =>
                {
                    b.HasOne("DataBase.Modules.Prescription", "Prescription")
                        .WithMany("Items")
                        .HasForeignKey("PrescriptionID")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("DataBase.Modules.Prescription", b =>
                {
                    b.HasOne("DataBase.Modules.Client", "Client")
                        .WithMany("PrescriptionsList")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("DataBase.Modules.Doctor", "Doctor")
                        .WithMany("PrescriptionsList")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("DataBase.Modules.TherapySession", b =>
                {
                    b.HasOne("DataBase.Modules.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("DataBase.Modules.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID");
                });

            modelBuilder.Entity("DataBase.Modules.Treatment", b =>
                {
                    b.HasOne("DataBase.Modules.TherapySession", "Session")
                        .WithMany("Treatments")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
