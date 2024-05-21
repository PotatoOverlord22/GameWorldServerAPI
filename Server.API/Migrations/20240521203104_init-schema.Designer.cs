﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.API.Utils;

#nullable disable

namespace Server.API.Migrations
{
    [DbContext(typeof(GamesContext))]
    [Migration("20240521203104_init-schema")]
    partial class Initschema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.API.Models.Achievement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfCoinsRewarded")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Server.API.Models.Challenge", b =>
                {
                    b.Property<Guid>("ChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChallengeAmount")
                        .HasColumnType("int");

                    b.Property<string>("ChallengeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChallengeReward")
                        .HasColumnType("int");

                    b.Property<string>("ChallengeRule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChallengeId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("Server.API.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PosterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PosterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Server.API.Models.FarmCell", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastTimeEnhanced")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastTimeInteracted")
                        .HasColumnType("datetime2");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("FarmCells");
                });

            modelBuilder.Entity("Server.API.Models.Font", b =>
                {
                    b.Property<Guid>("FontID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FontName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FontPrice")
                        .HasColumnType("int");

                    b.Property<string>("FontType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FontID");

                    b.ToTable("Fonts");
                });

            modelBuilder.Entity("Server.API.Models.Icon", b =>
                {
                    b.Property<Guid>("IconID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IconName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IconPrice")
                        .HasColumnType("int");

                    b.HasKey("IconID");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("Server.API.Models.InventoryResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ResourceId");

                    b.ToTable("InventoryResources");
                });

            modelBuilder.Entity("Server.API.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<Guid?>("ResourceToDestroyIdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResourceToInteractId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResourceToPlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResourceToDestroyIdId");

                    b.HasIndex("ResourceToInteractId");

                    b.HasIndex("ResourceToPlaceId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Server.API.Models.MarketBuyItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("MarketBuyItems");
                });

            modelBuilder.Entity("Server.API.Models.MarketSellResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResourceToSellId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResourceToSellId");

                    b.ToTable("MarketSellResources");
                });

            modelBuilder.Entity("Server.API.Models.PlayingCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Suit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PlayingCards");
                });

            modelBuilder.Entity("Server.API.Models.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Server.API.Models.ShopItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShopItems");
                });

            modelBuilder.Entity("Server.API.Models.Table", b =>
                {
                    b.Property<Guid>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TableBuyIn")
                        .HasColumnType("int");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TablePlayerLimit")
                        .HasColumnType("int");

                    b.HasKey("TableID");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Server.API.Models.Title", b =>
                {
                    b.Property<Guid>("TitleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TitleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TitlePrice")
                        .HasColumnType("int");

                    b.HasKey("TitleID");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Server.API.Models.Trade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResourceToGetQuantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("ResourceToGetResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResourceToGiveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ResourceToGiveQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("TradeCreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ResourceToGetResourceId");

                    b.HasIndex("ResourceToGiveId");

                    b.HasIndex("UserId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("Server.API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountOfItemsBought")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfTradesPerformed")
                        .HasColumnType("int");

                    b.Property<int>("Coins")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastTimeReceivedWater")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TradeHallUnlockTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserBet")
                        .HasColumnType("int");

                    b.Property<int>("UserChips")
                        .HasColumnType("int");

                    b.Property<Guid>("UserCurrentFontFontID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCurrentIconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserCurrentTableTableID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCurrentTitleTitleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserHandsPlayed")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserLastLogin")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserLevel")
                        .HasColumnType("int");

                    b.Property<int>("UserStack")
                        .HasColumnType("int");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserStreak")
                        .HasColumnType("int");

                    b.Property<int>("UserTablePlace")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserCurrentFontFontID");

                    b.HasIndex("UserCurrentTableTableID");

                    b.HasIndex("UserCurrentTitleTitleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Server.API.Models.Comment", b =>
                {
                    b.HasOne("Server.API.Models.User", "Poster")
                        .WithMany()
                        .HasForeignKey("PosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poster");
                });

            modelBuilder.Entity("Server.API.Models.FarmCell", b =>
                {
                    b.HasOne("Server.API.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.API.Models.InventoryResource", b =>
                {
                    b.HasOne("Server.API.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.API.Models.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Server.API.Models.Item", b =>
                {
                    b.HasOne("Server.API.Models.Resource", "ResourceToDestroyId")
                        .WithMany()
                        .HasForeignKey("ResourceToDestroyIdId");

                    b.HasOne("Server.API.Models.Resource", "ResourceToInteract")
                        .WithMany()
                        .HasForeignKey("ResourceToInteractId");

                    b.HasOne("Server.API.Models.Resource", "ResourceToPlace")
                        .WithMany()
                        .HasForeignKey("ResourceToPlaceId");

                    b.Navigation("ResourceToDestroyId");

                    b.Navigation("ResourceToInteract");

                    b.Navigation("ResourceToPlace");
                });

            modelBuilder.Entity("Server.API.Models.MarketBuyItem", b =>
                {
                    b.HasOne("Server.API.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Server.API.Models.MarketSellResource", b =>
                {
                    b.HasOne("Server.API.Models.Resource", "ResourceToSell")
                        .WithMany()
                        .HasForeignKey("ResourceToSellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResourceToSell");
                });

            modelBuilder.Entity("Server.API.Models.PlayingCard", b =>
                {
                    b.HasOne("Server.API.Models.User", null)
                        .WithMany("UserCurrentHand")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Server.API.Models.ShopItem", b =>
                {
                    b.HasOne("Server.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.API.Models.Trade", b =>
                {
                    b.HasOne("Server.API.Models.Resource", "ResourceToGetResource")
                        .WithMany()
                        .HasForeignKey("ResourceToGetResourceId");

                    b.HasOne("Server.API.Models.Resource", "ResourceToGive")
                        .WithMany()
                        .HasForeignKey("ResourceToGiveId");

                    b.HasOne("Server.API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ResourceToGetResource");

                    b.Navigation("ResourceToGive");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.API.Models.User", b =>
                {
                    b.HasOne("Server.API.Models.Font", "UserCurrentFont")
                        .WithMany()
                        .HasForeignKey("UserCurrentFontFontID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.API.Models.Table", "UserCurrentTable")
                        .WithMany()
                        .HasForeignKey("UserCurrentTableTableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.API.Models.Title", "UserCurrentTitle")
                        .WithMany()
                        .HasForeignKey("UserCurrentTitleTitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserCurrentFont");

                    b.Navigation("UserCurrentTable");

                    b.Navigation("UserCurrentTitle");
                });

            modelBuilder.Entity("Server.API.Models.User", b =>
                {
                    b.Navigation("UserCurrentHand");
                });
#pragma warning restore 612, 618
        }
    }
}