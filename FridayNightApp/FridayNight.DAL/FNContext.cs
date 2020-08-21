﻿using FridayNight.DAL.Model;
using FridayNight.DAL.Model.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.DAL
{
    public class FNContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BandRating> BandRatings { get; set; }
        public DbSet<TrackRating> TrackRatings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FriendlyCharge> FriendlyCharges { get; set; }
        public DbSet<InstagramLink> InstagramLinks { get; set; }
        public DbSet<YoutubeVideoLink> YoutubeVideoLinks { get; set; }
        public DbSet<LivePerformance> LivePerformances { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MusicPreferences> MusicPreferences { get; set; }
        public DbSet<MusicStyle> MusicStyles { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Track> Tracks { get; set; }
        //public DbSet<PlaylistInternal> MyProperty { get; set; }

        public FNContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RatingBase>().ToTable("ratings");
            modelBuilder.Entity<LinkContainerBase>().ToTable("link_containers");
            modelBuilder.Entity<ResourceBase>().ToTable("resources");
            modelBuilder.Entity<ActionRecordBase>().ToTable("action_records");
        }
    }
}