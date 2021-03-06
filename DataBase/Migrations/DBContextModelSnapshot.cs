// <auto-generated />
using System;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibraryEngSoft.Migrations
{
    [DbContext(typeof(PrescriptionContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBase.Modules.Credentials", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("DataBase.Modules.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrescriptionID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PrescriptionID");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("DataBase.Modules.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CredentialsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datebirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CredentialsId")
                        .IsUnique();

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DataBase.Modules.Prescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PrescriptionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Prescricoes");
                });

            modelBuilder.Entity("DataBase.Modules.TherapySession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptiveNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientId");

                    b.HasIndex("DoctorId");

                    b.ToTable("TherapySessions");
                });

            modelBuilder.Entity("DataBase.Modules.Exercise", b =>
                {
                    b.HasBaseType("DataBase.Modules.Item");

                    b.Property<TimeSpan>("TimeSugestion")
                        .HasColumnType("time");

                    b.HasDiscriminator().HasValue("Exercise");
                });

            modelBuilder.Entity("DataBase.Modules.Medicamento", b =>
                {
                    b.HasBaseType("DataBase.Modules.Item");

                    b.Property<double>("Dosage")
                        .HasColumnType("float");

                    b.Property<string>("Frequency")
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

                    b.Property<int?>("SessionID")
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

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("DataBase.Modules.Item", b =>
                {
                    b.HasOne("DataBase.Modules.Prescription", "Prescription")
                        .WithMany("Items")
                        .HasForeignKey("PrescriptionID")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("DataBase.Modules.Person", b =>
                {
                    b.HasOne("DataBase.Modules.Credentials", "Credentials")
                        .WithOne("Person")
                        .HasForeignKey("DataBase.Modules.Person", "CredentialsId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBase.Modules.Prescription", b =>
                {
                    b.HasOne("DataBase.Modules.Client", "Client")
                        .WithMany("PrescriptionsList")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("DataBase.Modules.Doctor", "Doctor")
                        .WithMany("PrescriptionsList")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("DataBase.Modules.TherapySession", b =>
                {
                    b.HasOne("DataBase.Modules.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("DataBase.Modules.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");
                });

            modelBuilder.Entity("DataBase.Modules.Treatment", b =>
                {
                    b.HasOne("DataBase.Modules.TherapySession", "Session")
                        .WithMany("Treatments")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });
#pragma warning restore 612, 618
        }
    }
}
