﻿// <auto-generated />
using System;
using ChessShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChessShop.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230718104551_removeStringLengthFromLastusername")]
    partial class removeStringLengthFromLastusername
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChessShop.Models.Category", b =>
                {
                    b.Property<Guid>("categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("code")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("displayorder")
                        .HasColumnType("integer");

                    b.Property<decimal>("inuse")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("lastuser")
                        .HasColumnType("uuid");

                    b.Property<string>("lastusername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modifiedtime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("categoryid");

                    b.ToTable("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
