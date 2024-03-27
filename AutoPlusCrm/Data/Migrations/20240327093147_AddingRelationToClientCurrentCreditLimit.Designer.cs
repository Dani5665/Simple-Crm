﻿// <auto-generated />
using System;
using AutoPlusCrm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoPlusCrm.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240327093147_AddingRelationToClientCurrentCreditLimit")]
    partial class AddingRelationToClientCurrentCreditLimit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserStoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserStoreId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Primary key");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountablePerson")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the accountable person (MOL)");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Address of client");

                    b.Property<string>("Bulstat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Firm bulstat");

                    b.Property<string>("CataloguePassword")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Password for the catalogue");

                    b.Property<string>("CatalogueUser")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Username for the catalogue");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("City where the client is registered");

                    b.Property<string>("ClientDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Short description about the client");

                    b.Property<int?>("CreditLimitId")
                        .HasColumnType("int");

                    b.Property<int?>("DelayedPaymentPeriod")
                        .HasColumnType("int")
                        .HasComment("Delayed payment period in days");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Client email address");

                    b.Property<int?>("MainDiscountId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the client");

                    b.Property<string>("PersonToContact")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Person to contact");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Client phone number");

                    b.Property<int>("RetailerStoresId")
                        .HasColumnType("int");

                    b.Property<string>("SkypeUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Skype username");

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Website url");

                    b.HasKey("Id");

                    b.HasIndex("CreditLimitId");

                    b.HasIndex("MainDiscountId");

                    b.HasIndex("RetailerStoresId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ClientStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("The address of the store");

                    b.Property<string>("CataloguePassword")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Password for AP catalogue");

                    b.Property<string>("CatalogueUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Username for AP catalogue");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Id of the client");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The email of the person to contact");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The name of the store");

                    b.Property<int?>("NumberOfMechanics")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("The number of mechanics in the store");

                    b.Property<int?>("NumberOfVehicles")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("The number of vehicles in the store");

                    b.Property<int?>("NumberOfWorkers")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .HasComment("The number of workers in the store");

                    b.Property<string>("PersonToContact")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("The name of the person to contact");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The phone number of the person to contact");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ClientType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The type of the client (Store, Service...)");

                    b.HasKey("Id");

                    b.ToTable("ClientTypes");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.CreditLimit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Id of the client");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2")
                        .HasComment("Date and time when the credit limit was created");

                    b.Property<int>("Value")
                        .HasColumnType("int")
                        .HasComment("Number of the credit limit");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("CreditLimits");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.FutureTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The city in which the client store is located");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2")
                        .HasComment("The date when the visit will be made");

                    b.Property<bool>("Iscompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The region in which the client store is located");

                    b.Property<int>("RetailerStoreId")
                        .HasColumnType("int");

                    b.Property<string>("TaskDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Description of the task");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ClientId");

                    b.HasIndex("RetailerStoreId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.MainDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Id of the client");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2")
                        .HasComment("Date and time when the discount was created");

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int")
                        .HasComment("Number of the discount in percentage");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("MainDiscounts");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.RetailerStores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RetailerStores");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The city of the visited location");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasComment("Id of the client");

                    b.Property<int?>("ClientStoreId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientTypeId")
                        .HasColumnType("int")
                        .HasComment("Client type id");

                    b.Property<string>("CustomerComments")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Any information that came from the client. It can be about our products, competitors, his impressions...");

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("datetime2")
                        .HasComment("The date when the visit happened");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The region of the visited location");

                    b.Property<int>("RetailerStoreId")
                        .HasColumnType("int");

                    b.Property<int?>("RetailerStoresId")
                        .HasColumnType("int");

                    b.Property<string>("TakenActions")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Actions taken from the visitor so that the client starts using our services and products ");

                    b.Property<string>("VisitCreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VisitPurpose")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasComment("Purpose of the visit");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ClientStoreId");

                    b.HasIndex("ClientTypeId");

                    b.HasIndex("RetailerStoreId");

                    b.HasIndex("RetailerStoresId");

                    b.HasIndex("VisitCreatorId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.VisitGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("A grade of the visit (Positive/Neutral/Negative)");

                    b.Property<int>("VisitClassId")
                        .HasColumnType("int")
                        .HasComment("Id of the visit");

                    b.HasKey("Id");

                    b.HasIndex("VisitClassId");

                    b.ToTable("VisitGrades");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.RetailerStores", "UserStore")
                        .WithMany()
                        .HasForeignKey("UserStoreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserStore");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.Client", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.CreditLimit", "CreditLimit")
                        .WithMany()
                        .HasForeignKey("CreditLimitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AutoPlusCrm.Data.Models.MainDiscount", "MainDiscount")
                        .WithMany()
                        .HasForeignKey("MainDiscountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AutoPlusCrm.Data.Models.RetailerStores", "RetailerStores")
                        .WithMany("Clients")
                        .HasForeignKey("RetailerStoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditLimit");

                    b.Navigation("MainDiscount");

                    b.Navigation("RetailerStores");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ClientStore", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.Client", "Client")
                        .WithMany("ClientStore")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.CreditLimit", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.Client", "Client")
                        .WithMany("CreditLimits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.FutureTask", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPlusCrm.Data.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPlusCrm.Data.Models.RetailerStores", "RetailerStore")
                        .WithMany()
                        .HasForeignKey("RetailerStoreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Client");

                    b.Navigation("RetailerStore");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.MainDiscount", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.Client", "Client")
                        .WithMany("MainDiscounts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.Visit", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.Client", "Client")
                        .WithMany("Visits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPlusCrm.Data.Models.ClientStore", null)
                        .WithMany("Visits")
                        .HasForeignKey("ClientStoreId");

                    b.HasOne("AutoPlusCrm.Data.Models.ClientType", "ClientType")
                        .WithMany()
                        .HasForeignKey("ClientTypeId");

                    b.HasOne("AutoPlusCrm.Data.Models.RetailerStores", "RetailerStore")
                        .WithMany()
                        .HasForeignKey("RetailerStoreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AutoPlusCrm.Data.Models.RetailerStores", null)
                        .WithMany("Visits")
                        .HasForeignKey("RetailerStoresId");

                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", "VisitCreator")
                        .WithMany()
                        .HasForeignKey("VisitCreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("ClientType");

                    b.Navigation("RetailerStore");

                    b.Navigation("VisitCreator");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.VisitGrade", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AutoPlusCrm.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.Client", b =>
                {
                    b.Navigation("ClientStore");

                    b.Navigation("CreditLimits");

                    b.Navigation("MainDiscounts");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.ClientStore", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("AutoPlusCrm.Data.Models.RetailerStores", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}