using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using hotell.web.Models;

namespace hotell.web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170316232556_inital migration")]
    partial class initalmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BookinDate");

                    b.Property<string>("CustomerAdress");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("CustomerPhone")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsCheckedIn");

                    b.Property<DateTime>("Modified");

                    b.Property<bool>("RoomNumber");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Domain.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Floor");

                    b.Property<bool>("IsAvaliable");

                    b.Property<DateTime>("Modified");

                    b.Property<decimal>("Price");

                    b.Property<int>("RomNumber");

                    b.Property<string>("RomeName");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });
        }
    }
}
