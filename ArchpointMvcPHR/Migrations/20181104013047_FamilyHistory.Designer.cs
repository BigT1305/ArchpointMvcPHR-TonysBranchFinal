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
    [Migration("20181104013047_FamilyHistory")]
    partial class FamilyHistory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArchpointMvcPHR.Models.DoctorAppointment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ApptDate")
                        .HasMaxLength(80);

                    b.Property<string>("Comments");

                    b.Property<string>("Email")
                        .HasMaxLength(80);

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Fax")
                        .HasMaxLength(40);

                    b.Property<int>("MedicalProviderId")
                        .HasMaxLength(80);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ReasonForVisit")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("RemindMe")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("SymptomComplaint")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("DoctorAppointment");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.EmergencyContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("EmerContactCity")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("EmerContactCountry")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("EmerContactEmail")
                        .HasMaxLength(80);

                    b.Property<string>("EmerContactStateProvince")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("EmerContactStreetAddress")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("EmerContactZip")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("EveningPhone")
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("HomePhone")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("RelationshipToPatient")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("EmergencyContact");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.Employment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("EmployerName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Employment");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.FamilyHistory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CauseOfDeath")
                        .HasMaxLength(150);

                    b.Property<string>("Comments")
                        .HasMaxLength(500);

                    b.Property<string>("Disease")
                        .IsRequired();

                    b.Property<string>("FamilyMember")
                        .HasMaxLength(60);

                    b.Property<string>("FirstName")
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("FamilyHistory");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorizationPhoneNum")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(20);

                    b.Property<string>("GroupNo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("InsuranceCity")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("InsuranceCountry")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("InsuranceName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("InsurancePhoneNum")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("InsuranceState")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("InsuranceStreetAddress")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("MedicaidClaimNum");

                    b.Property<string>("MedicareClaimNum");

                    b.Property<DateTime>("MedicareMedicaidEffectiveDate")
                        .HasMaxLength(20);

                    b.Property<DateTime>("PlanEffectiveDate")
                        .HasMaxLength(20);

                    b.Property<string>("PolicyHolderFirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("PolicyHolderLastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("PolicyHolderMidInit")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("PolicyIdNo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PrimaryOrSecondary")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("RelationshipToPolicyHolder")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SocialSecurityNo")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("Insurance");
                });

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

            modelBuilder.Entity("ArchpointMvcPHR.Models.MedicalHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeAtOnset")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Comments")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DateOfDiagnosis")
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateResolved")
                        .HasMaxLength(80);

                    b.Property<string>("DiseaseDisorder")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("MedicalProviderId")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("MedicalHistory");
                });

            modelBuilder.Entity("ArchpointMvcPHR.Models.MedicalProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveOrInactive")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Email")
                        .HasMaxLength(80);

                    b.Property<string>("Fax")
                        .HasMaxLength(40);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PrimaryOrNot")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("TypeOfSpecialty")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("MedicalProvider");
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

            modelBuilder.Entity("ArchpointMvcPHR.Models.PersonalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("HomePhone")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("MiddleInitial")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Religion")
                        .HasMaxLength(80);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SocialSecurityNum")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("PersonalInfo");
                });
#pragma warning restore 612, 618
        }
    }
}