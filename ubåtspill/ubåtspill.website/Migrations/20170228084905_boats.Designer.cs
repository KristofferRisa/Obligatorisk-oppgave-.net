using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ubåtspill.website.Models;

namespace ubåtspill.website.Migrations
{
    [DbContext(typeof(HighscoreContext))]
    [Migration("20170228084905_boats")]
    partial class boats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ubåtspill.website.Models.Boat", b =>
                {
                    b.Property<int>("BoatId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.Property<int>("Speed");

                    b.HasKey("BoatId");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("ubåtspill.website.Models.Highscore", b =>
                {
                    b.Property<int>("HighscoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("Score");

                    b.HasKey("HighscoreId");

                    b.ToTable("Highscores");
                });
        }
    }
}
