﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using music.Models;

#nullable disable

namespace music.Migrations
{
    [DbContext(typeof(MusicContext))]
    partial class MusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("music.Models.Artist", b =>
                {
                    b.Property<long>("Artist_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Artist_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("Bio")
                        .HasColumnType("bigint");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Artist_Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("music.Models.Login", b =>
                {
                    b.Property<long>("Login_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Login_Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("music.Models.Playlist", b =>
                {
                    b.Property<int>("Playlist_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("Description")
                        .HasColumnType("bigint");

                    b.Property<string>("Playlist_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserProfileUP_Id")
                        .HasColumnType("int");

                    b.HasKey("Playlist_Id");

                    b.HasIndex("UserProfileUP_Id");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("music.Models.Songs", b =>
                {
                    b.Property<int>("Song_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Added_date")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeOnly>("Duration")
                        .HasColumnType("time(6)");

                    b.Property<int?>("Playlist_Id")
                        .HasColumnType("int");

                    b.Property<string>("artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Song_Id");

                    b.HasIndex("Playlist_Id");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("music.Models.UserProfile", b =>
                {
                    b.Property<int>("UP_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UP_Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("music.Models.user", b =>
                {
                    b.Property<long>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("User_mobile")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("age")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("User_Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("music.Models.Playlist", b =>
                {
                    b.HasOne("music.Models.UserProfile", null)
                        .WithMany("Playlists")
                        .HasForeignKey("UserProfileUP_Id");
                });

            modelBuilder.Entity("music.Models.Songs", b =>
                {
                    b.HasOne("music.Models.Playlist", null)
                        .WithMany("Songs")
                        .HasForeignKey("Playlist_Id");
                });

            modelBuilder.Entity("music.Models.Playlist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("music.Models.UserProfile", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}