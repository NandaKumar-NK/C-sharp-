﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFIRST.Models;

public partial class TrainTicketBookingContext : DbContext
{
    public TrainTicketBookingContext()
    {
    }

    public TrainTicketBookingContext(DbContextOptions<TrainTicketBookingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDeatil> BookingDeatils { get; set; }

    public virtual DbSet<PassangerDetail> PassangerDetails { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<SeatAllocation> SeatAllocations { get; set; }

    public virtual DbSet<TrainDetail> TrainDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=LAPTOP-KR3SF32I\\SQLEXPRESS;database=Train_TicketBooking;integrated security=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingDeatil>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__booking___ED7364E12799E6C8");

            entity.ToTable("booking_deatils");

            entity.Property(e => e.TicketId).HasColumnName("Ticket_id");
            entity.Property(e => e.CompartmentType)
                .HasMaxLength(20)
                .HasColumnName("compartment_type");
            entity.Property(e => e.PassId).HasColumnName("pass_id");
            entity.Property(e => e.SeatNo).HasColumnName("seat_no");
            entity.Property(e => e.TDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("T_date");
            entity.Property(e => e.TrainId).HasColumnName("train_id");

            entity.HasOne(d => d.Pass).WithMany(p => p.BookingDeatils)
                .HasForeignKey(d => d.PassId)
                .HasConstraintName("FK_PASSID");

            entity.HasOne(d => d.Train).WithMany(p => p.BookingDeatils)
                .HasForeignKey(d => d.TrainId)
                .HasConstraintName("FK__booking_d__train__403A8C7D");
        });

        modelBuilder.Entity<PassangerDetail>(entity =>
        {
            entity.HasKey(e => e.PassId).HasName("PK__passange__EFA330E77E580A0C");

            entity.ToTable("passanger_details");

            entity.Property(e => e.PassId).HasColumnName("pass_id");
            entity.Property(e => e.MobileNo).HasColumnName("mobile_no");
            entity.Property(e => e.PassangerName)
                .HasMaxLength(20)
                .HasColumnName("passanger_name");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CompartmentCount)
                .HasMaxLength(20)
                .HasColumnName("Compartment_count");
            entity.Property(e => e.CompartmentType)
                .HasMaxLength(20)
                .HasColumnName("Compartment_type");
            entity.Property(e => e.TotalSeatCount).HasColumnName("Total_SeatCount");
            entity.Property(e => e.TrainId).HasColumnName("train_id");

            entity.HasOne(d => d.Train).WithMany()
                .HasForeignKey(d => d.TrainId)
                .HasConstraintName("FK__Seats__train_id__38996AB5");
        });

        modelBuilder.Entity<SeatAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Seat_Allocation");

            entity.Property(e => e.CompartmentType)
                .HasMaxLength(20)
                .HasColumnName("Compartment_type");
            entity.Property(e => e.SeatNo).HasColumnName("seat_no");
            entity.Property(e => e.SeatStatus)
                .HasMaxLength(20)
                .HasColumnName("Seat_Status");
            entity.Property(e => e.TDate)
                .HasColumnType("date")
                .HasColumnName("T_Date");
            entity.Property(e => e.TrainId).HasColumnName("train_id");

            entity.HasOne(d => d.Train).WithMany()
                .HasForeignKey(d => d.TrainId)
                .HasConstraintName("FK__Seat_Allo__train__5070F446");
        });

        modelBuilder.Entity<TrainDetail>(entity =>
        {
            entity.HasKey(e => e.TrainId).HasName("PK__Train_de__9F1CF685FABAB8D7");

            entity.ToTable("Train_details");

            entity.Property(e => e.TrainId)
                .ValueGeneratedNever()
                .HasColumnName("train_id");
            entity.Property(e => e.Distination).HasMaxLength(20);
            entity.Property(e => e.Sources).HasMaxLength(20);
            entity.Property(e => e.TrainName)
                .HasMaxLength(20)
                .HasColumnName("train_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
