﻿// <auto-generated />
using System;
using AddnodeBalkan.TableTennis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddnodeBalkan.TableTennis.Data.Migrations
{
    [DbContext(typeof(TableTennisContext))]
    [Migration("20200626170636_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SettingsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.MatchSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sets")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MatchSettings");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sets")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("ScoreId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Match", b =>
                {
                    b.HasOne("AddnodeBalkan.TableTennis.Models.MatchSettings", "Settings")
                        .WithMany()
                        .HasForeignKey("SettingsId");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Player", b =>
                {
                    b.HasOne("AddnodeBalkan.TableTennis.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("AddnodeBalkan.TableTennis.Models.Team", b =>
                {
                    b.HasOne("AddnodeBalkan.TableTennis.Models.Match", "Match")
                        .WithMany("Teams")
                        .HasForeignKey("MatchId");

                    b.HasOne("AddnodeBalkan.TableTennis.Models.Score", "Score")
                        .WithMany()
                        .HasForeignKey("ScoreId");
                });
#pragma warning restore 612, 618
        }
    }
}
