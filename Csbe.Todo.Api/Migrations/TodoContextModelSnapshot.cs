﻿// <auto-generated />
using System;
using Csbe.Todo.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Csbe.Todo.Api.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Csbe.Todo.Api.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("FinishDate");

                    b.Property<string>("Importance");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.Property<long>("User_ID");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("Csbe.Todo.Api.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PwHash");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
