﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ScladCRUD.Models;

#nullable disable

namespace ScladCRUD.Migrations
{
    [DbContext(typeof(ScladContext))]
    [Migration("20230516184409_db1")]
    partial class db1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "btree_gin");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "btree_gist");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "citext");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "cube");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "dblink");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "dict_int");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "dict_xsyn");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "earthdistance");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "fuzzystrmatch");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "hstore");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "intarray");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "ltree");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pg_stat_statements");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pg_trgm");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pgcrypto");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pgrowlocks");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "pgstattuple");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "tablefunc");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "unaccent");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "xml2");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ScladCRUD.Models.Catalog1", b =>
                {
                    b.Property<int>("IdCatalog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_catalog");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCatalog"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("integer")
                        .HasColumnName("id_product");

                    b.Property<int?>("Product1IdProduct")
                        .HasColumnType("integer");

                    b.HasKey("IdCatalog")
                        .HasName("catalog1_pkey");

                    b.HasIndex("IdProduct");

                    b.HasIndex("Product1IdProduct");

                    b.ToTable("catalog1");
                });

            modelBuilder.Entity("ScladCRUD.Models.Manager1", b =>
                {
                    b.Property<int>("IdManager")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_manager");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdManager"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(900)
                        .HasColumnType("character varying(900)")
                        .HasColumnName("avatar");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("manager_name");

                    b.Property<string>("Parol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("parol");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("post");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("tel");

                    b.HasKey("IdManager")
                        .HasName("manager1_pkey");

                    b.ToTable("manager1");
                });

            modelBuilder.Entity("ScladCRUD.Models.Order1", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_order");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdOrder"));

                    b.Property<string>("Articul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("articul");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("client_name");

                    b.Property<int?>("IdClient")
                        .HasColumnType("integer")
                        .HasColumnName("id_client");

                    b.Property<int?>("IdProduct")
                        .HasColumnType("integer")
                        .HasColumnName("id_product");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("product_name");

                    b.Property<int>("Qantity")
                        .HasColumnType("integer")
                        .HasColumnName("qantity");

                    b.HasKey("IdOrder")
                        .HasName("order1_pkey");

                    b.HasIndex("IdProduct");

                    b.ToTable("order1");
                });

            modelBuilder.Entity("ScladCRUD.Models.Product1", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_product");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdProduct"));

                    b.Property<string>("Articul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("articul");

                    b.Property<int>("Cost")
                        .HasColumnType("integer")
                        .HasColumnName("cost");

                    b.Property<int>("Margin")
                        .HasColumnType("integer")
                        .HasColumnName("margin");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("product_name");

                    b.Property<string>("ProductPic")
                        .HasMaxLength(900)
                        .HasColumnType("character varying(900)")
                        .HasColumnName("product_pic");

                    b.HasKey("IdProduct")
                        .HasName("product1_pkey");

                    b.ToTable("product1");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScladCRUD.Models.Catalog1", b =>
                {
                    b.HasOne("ScladCRUD.Models.Product1", "IdProductNavigation")
                        .WithMany("Catalog1")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("catalog1_id_product_fkey");

                    b.HasOne("ScladCRUD.Models.Product1", "Product1")
                        .WithMany()
                        .HasForeignKey("Product1IdProduct");

                    b.Navigation("IdProductNavigation");

                    b.Navigation("Product1");
                });

            modelBuilder.Entity("ScladCRUD.Models.Order1", b =>
                {
                    b.HasOne("ScladCRUD.Models.Product1", "IdProductNavigation")
                        .WithMany("Order1")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("order1_id_product_fkey");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("ScladCRUD.Models.Product1", b =>
                {
                    b.Navigation("Catalog1");

                    b.Navigation("Order1");
                });
#pragma warning restore 612, 618
        }
    }
}