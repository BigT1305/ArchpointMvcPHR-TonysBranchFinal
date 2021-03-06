﻿// <auto-generated />
using System;
using ArchpointMvcPHR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArchpointMvcPHR.Migrations
{
    [DbContext(typeof(ArchpointMvcPHRContext))]
    [Migration("20181024050154_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArchpointMvcPHR.Models.LegalDocument", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttorneyFirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("AttorneyLastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("AttorneyPhone")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Comments")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DateMedPowerOfAttorney")
                        .HasMaxLength(60);

                    b.Property<DateTime>("DateUpdatedMedPowerOfAttorney")
                        .HasMaxLength(60);

                    b.Property<DateTime>("DnrDateSign")
                        .HasMaxLength(60);

                    b.Property<DateTime>("DnrDateUpdate")
                        .HasMaxLength(60);

                    b.Property<string>("DoNotResuscitate")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("DocumentContactFirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DocumentContactLastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DocumentContactPhone")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("DocumentLocation")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("FamilyAware")
                        .HasMaxLength(3);

                    b.Property<string>("HealthCareProxy")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<DateTime>("HealthCareProxyDateSign")
                        .HasMaxLength(60);

                    b.Property<DateTime>("HealthCareProxyLastUpdate")
                        .HasMaxLength(60);

                    b.Property<string>("HealthCareProxyName")
                        .HasMaxLength(60);

                    b.Property<string>("MedPowerOfAttorney")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("MedPowerOfAttorneyCopyOnFile")
                        .HasMaxLength(3);

                    b.Property<string>("MedPowerOfAttorneyName")
                        .HasMaxLength(100);

                    b.Property<string>("OrganDonorDocument")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<DateTime>("OrganDonorDocumentDateSign")
                        .HasMaxLength(60);

                    b.Property<DateTime>("OrganDonorDocumentLastUpdate")
                        .HasMaxLength(60);

                    b.Property<string>("Will")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("WillCopy")
                        .HasMaxLength(3);

                    b.Property<DateTime>("WillDateSigned")
                        .HasMaxLength(60);

                    b.Property<DateTime>("WillLastUpdated")
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("LegalDocument");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.Medication", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dosage")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Physician")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("Quantity");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Medication");
                });
#pragma warning restore 612, 618
        }
    }
}
