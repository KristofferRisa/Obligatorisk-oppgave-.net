using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ubåtspill.website.Models;

namespace ubåtspill.website.Migrations
{
    [DbContext(typeof(HighscoreContext))]
    partial class HighscoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
