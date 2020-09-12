using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayNight.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "link_containers",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_link_container_base", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "music_preferences",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_music_preferences", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    discriminator = table.Column<string>(nullable: false),
                    likes_count = table.Column<int>(nullable: true),
                    views_count = table.Column<int>(nullable: true),
                    opened_contact_count = table.Column<int>(nullable: true),
                    listened_count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rating_base", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "action_records",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    date_time = table.Column<DateTime>(nullable: false),
                    discriminator = table.Column<string>(nullable: false),
                    talent_uid = table.Column<Guid>(nullable: true),
                    talent_seeker_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_action_record_base", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "live_performances",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    performance_type = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    location_uid = table.Column<Guid>(nullable: true),
                    duration = table.Column<TimeSpan>(nullable: true),
                    is_private = table.Column<bool>(nullable: false),
                    photo_uid = table.Column<Guid>(nullable: true),
                    music_talent_uid = table.Column<Guid>(nullable: true),
                    talent_seeker_uid = table.Column<Guid>(nullable: true),
                    state = table.Column<int>(nullable: false),
                    in_app_link_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_live_performances", x => x.uid);
                    table.ForeignKey(
                        name: "fk_live_performances_link_container_base_in_app_link_uid",
                        column: x => x.in_app_link_uid,
                        principalTable: "link_containers",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    country = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    google_coordinates = table.Column<string>(nullable: true),
                    creation_date = table.Column<DateTime>(nullable: false),
                    talent_seeker_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_locations", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "music_instrument",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    music_talent_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_music_instrument", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "music_styles",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    name = table.Column<int>(nullable: false),
                    music_preferences_uid = table.Column<Guid>(nullable: true),
                    music_talent_uid = table.Column<Guid>(nullable: true),
                    track_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_music_styles", x => x.uid);
                    table.ForeignKey(
                        name: "fk_music_styles_music_preferences_music_preferences_uid",
                        column: x => x.music_preferences_uid,
                        principalTable: "music_preferences",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "resources",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    resource = table.Column<byte[]>(nullable: true),
                    discriminator = table.Column<string>(nullable: false),
                    music_talent_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_resource_base", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    registration_date = table.Column<DateTime>(nullable: false),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    is_confirmed = table.Column<bool>(nullable: false),
                    discriminator = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    photo_cover_uid = table.Column<Guid>(nullable: true),
                    youtube_video_uid = table.Column<Guid>(nullable: true),
                    instagram_link_uid = table.Column<Guid>(nullable: true),
                    rating_uid = table.Column<Guid>(nullable: true),
                    desirable_payment = table.Column<decimal>(nullable: true),
                    TalentSeeker_name = table.Column<string>(nullable: true),
                    TalentSeeker_phone = table.Column<string>(nullable: true),
                    music_preferences_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_account_base", x => x.uid);
                    table.ForeignKey(
                        name: "fk_accounts_link_container_base_instagram_link_uid",
                        column: x => x.instagram_link_uid,
                        principalTable: "link_containers",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_accounts_resource_base_photo_cover_uid",
                        column: x => x.photo_cover_uid,
                        principalTable: "resources",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_accounts_rating_base_rating_uid",
                        column: x => x.rating_uid,
                        principalTable: "ratings",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_accounts_link_container_base_youtube_video_uid",
                        column: x => x.youtube_video_uid,
                        principalTable: "link_containers",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_talent_seekers_music_preferences_music_preferences_uid",
                        column: x => x.music_preferences_uid,
                        principalTable: "music_preferences",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tracks",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    owner_uid = table.Column<Guid>(nullable: true),
                    track_name = table.Column<string>(nullable: true),
                    rating_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracks", x => x.uid);
                    table.ForeignKey(
                        name: "fk_tracks_account_base_owner_uid",
                        column: x => x.owner_uid,
                        principalTable: "accounts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tracks_rating_base_rating_uid",
                        column: x => x.rating_uid,
                        principalTable: "ratings",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_accounts_instagram_link_uid",
                table: "accounts",
                column: "instagram_link_uid");

            migrationBuilder.CreateIndex(
                name: "ix_accounts_photo_cover_uid",
                table: "accounts",
                column: "photo_cover_uid");

            migrationBuilder.CreateIndex(
                name: "ix_accounts_rating_uid",
                table: "accounts",
                column: "rating_uid");

            migrationBuilder.CreateIndex(
                name: "ix_accounts_youtube_video_uid",
                table: "accounts",
                column: "youtube_video_uid");

            migrationBuilder.CreateIndex(
                name: "ix_talent_seekers_music_preferences_uid",
                table: "accounts",
                column: "music_preferences_uid");

            migrationBuilder.CreateIndex(
                name: "ix_viewed_talents_talent_seeker_uid",
                table: "action_records",
                column: "talent_seeker_uid");

            migrationBuilder.CreateIndex(
                name: "ix_viewed_talents_talent_uid",
                table: "action_records",
                column: "talent_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_in_app_link_uid",
                table: "live_performances",
                column: "in_app_link_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_location_uid",
                table: "live_performances",
                column: "location_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_music_talent_uid",
                table: "live_performances",
                column: "music_talent_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_photo_uid",
                table: "live_performances",
                column: "photo_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_talent_seeker_uid",
                table: "live_performances",
                column: "talent_seeker_uid");

            migrationBuilder.CreateIndex(
                name: "ix_locations_talent_seeker_uid",
                table: "locations",
                column: "talent_seeker_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_instrument_music_talent_uid",
                table: "music_instrument",
                column: "music_talent_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_music_preferences_uid",
                table: "music_styles",
                column: "music_preferences_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_music_talent_uid",
                table: "music_styles",
                column: "music_talent_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_track_uid",
                table: "music_styles",
                column: "track_uid");

            migrationBuilder.CreateIndex(
                name: "ix_photos_music_talent_uid",
                table: "resources",
                column: "music_talent_uid");

            migrationBuilder.CreateIndex(
                name: "ix_tracks_owner_uid",
                table: "tracks",
                column: "owner_uid");

            migrationBuilder.CreateIndex(
                name: "ix_tracks_rating_uid",
                table: "tracks",
                column: "rating_uid");

            migrationBuilder.AddForeignKey(
                name: "fk_viewed_talents_account_base_talent_seeker_uid",
                table: "action_records",
                column: "talent_seeker_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_viewed_talents_account_base_talent_uid",
                table: "action_records",
                column: "talent_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_resource_base_photo_uid",
                table: "live_performances",
                column: "photo_uid",
                principalTable: "resources",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_account_base_music_talent_uid",
                table: "live_performances",
                column: "music_talent_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_account_base_talent_seeker_uid",
                table: "live_performances",
                column: "talent_seeker_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_locations_location_uid",
                table: "live_performances",
                column: "location_uid",
                principalTable: "locations",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_locations_account_base_talent_seeker_uid",
                table: "locations",
                column: "talent_seeker_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_music_instrument_account_base_music_talent_uid",
                table: "music_instrument",
                column: "music_talent_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_music_styles_account_base_music_talent_uid",
                table: "music_styles",
                column: "music_talent_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_music_styles_tracks_track_uid",
                table: "music_styles",
                column: "track_uid",
                principalTable: "tracks",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_photos_account_base_music_talent_uid",
                table: "resources",
                column: "music_talent_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_accounts_link_container_base_instagram_link_uid",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "fk_accounts_link_container_base_youtube_video_uid",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "fk_accounts_resource_base_photo_cover_uid",
                table: "accounts");

            migrationBuilder.DropTable(
                name: "action_records");

            migrationBuilder.DropTable(
                name: "live_performances");

            migrationBuilder.DropTable(
                name: "music_instrument");

            migrationBuilder.DropTable(
                name: "music_styles");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "tracks");

            migrationBuilder.DropTable(
                name: "link_containers");

            migrationBuilder.DropTable(
                name: "resources");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "music_preferences");
        }
    }
}
