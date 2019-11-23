﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VRChatActivityLogViewer;

namespace VRChatActivityLogViewer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191118081202_VRChatActivityLogViewer")]
    partial class VRChatActivityLogViewer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("VRChatActivityLogViewer.ActivityLog", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NotificationID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorldID")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorldName")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("ActivityLogs");
                });
#pragma warning restore 612, 618
        }
    }
}