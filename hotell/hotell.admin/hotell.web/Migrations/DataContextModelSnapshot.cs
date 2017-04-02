using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using hotell.web.Models;

namespace hotell.web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("NumberOfReservations");

                    b.HasKey("Id");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("Domain.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CustomerAdress");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("CustomerPhone")
                        .IsRequired();

                    b.Property<DateTime>("FromDate");

                    b.Property<bool>("IsCheckedIn");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ReservationCode");

                    b.Property<int>("RoomNumber");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Domain.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Floor");

                    b.Property<DateTime>("Modified");

                    b.Property<decimal>("Price");

                    b.Property<string>("RoomName");

                    b.Property<int>("RoomNumber");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });
        }
    }
}
