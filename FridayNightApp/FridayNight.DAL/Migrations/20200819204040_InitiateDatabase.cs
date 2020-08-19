using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayNight.DAL.Migrations
{
    public partial class InitiateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "friendly_charges",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    state = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_friendly_charges", x => x.uid);
                });

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
                    band_uid = table.Column<Guid>(nullable: true),
                    place_uid = table.Column<Guid>(nullable: true)
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
                    date = table.Column<DateTime>(nullable: false),
                    band_uid = table.Column<Guid>(nullable: true),
                    place_uid = table.Column<Guid>(nullable: true),
                    is_approved = table.Column<bool>(nullable: false),
                    state = table.Column<int>(nullable: false),
                    charge_uid = table.Column<Guid>(nullable: true),
                    duration = table.Column<TimeSpan>(nullable: true),
                    is_private = table.Column<bool>(nullable: false),
                    location_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_live_performances", x => x.uid);
                    table.ForeignKey(
                        name: "fk_live_performances_friendly_charges_charge_uid",
                        column: x => x.charge_uid,
                        principalTable: "friendly_charges",
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
                    place_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_locations", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    location_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contacts", x => x.uid);
                    table.ForeignKey(
                        name: "fk_contacts_locations_location_uid",
                        column: x => x.location_uid,
                        principalTable: "locations",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "music_styles",
                columns: table => new
                {
                    uid = table.Column<Guid>(nullable: false),
                    name = table.Column<int>(nullable: false),
                    band_uid = table.Column<Guid>(nullable: true),
                    music_preferences_uid = table.Column<Guid>(nullable: true),
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
                    band_uid = table.Column<Guid>(nullable: true)
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
                    email = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    discriminator = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    photo_cover_uid = table.Column<Guid>(nullable: true),
                    youtube_video_uid = table.Column<Guid>(nullable: true),
                    instagram_link_uid = table.Column<Guid>(nullable: true),
                    contact_uid = table.Column<Guid>(nullable: true),
                    rating_uid = table.Column<Guid>(nullable: true),
                    place_type = table.Column<int>(nullable: true),
                    Place_name = table.Column<string>(nullable: true),
                    Place_contact_uid = table.Column<Guid>(nullable: true),
                    music_preferences_uid = table.Column<Guid>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    User_music_preferences_uid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accounts", x => x.uid);
                    table.ForeignKey(
                        name: "fk_accounts_contacts_contact_uid",
                        column: x => x.contact_uid,
                        principalTable: "contacts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "fk_accounts_contacts_contact_uid1",
                        column: x => x.Place_contact_uid,
                        principalTable: "contacts",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_accounts_music_preferences_music_preferences_uid",
                        column: x => x.music_preferences_uid,
                        principalTable: "music_preferences",
                        principalColumn: "uid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_accounts_music_preferences_music_preferences_uid1",
                        column: x => x.User_music_preferences_uid,
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
                        name: "fk_tracks_accounts_owner_uid",
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
                name: "ix_accounts_contact_uid",
                table: "accounts",
                column: "contact_uid");

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
                name: "ix_accounts_contact_uid1",
                table: "accounts",
                column: "Place_contact_uid");

            migrationBuilder.CreateIndex(
                name: "ix_accounts_music_preferences_uid",
                table: "accounts",
                column: "music_preferences_uid");

            migrationBuilder.CreateIndex(
                name: "ix_accounts_music_preferences_uid1",
                table: "accounts",
                column: "User_music_preferences_uid");

            migrationBuilder.CreateIndex(
                name: "ix_viewed_bands_band_uid",
                table: "action_records",
                column: "band_uid");

            migrationBuilder.CreateIndex(
                name: "ix_viewed_bands_place_uid",
                table: "action_records",
                column: "place_uid");

            migrationBuilder.CreateIndex(
                name: "ix_contacts_location_uid",
                table: "contacts",
                column: "location_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_band_uid",
                table: "live_performances",
                column: "band_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_charge_uid",
                table: "live_performances",
                column: "charge_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_location_uid",
                table: "live_performances",
                column: "location_uid");

            migrationBuilder.CreateIndex(
                name: "ix_live_performances_place_uid",
                table: "live_performances",
                column: "place_uid");

            migrationBuilder.CreateIndex(
                name: "ix_locations_place_uid",
                table: "locations",
                column: "place_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_band_uid",
                table: "music_styles",
                column: "band_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_music_preferences_uid",
                table: "music_styles",
                column: "music_preferences_uid");

            migrationBuilder.CreateIndex(
                name: "ix_music_styles_track_uid",
                table: "music_styles",
                column: "track_uid");

            migrationBuilder.CreateIndex(
                name: "ix_photos_band_uid",
                table: "resources",
                column: "band_uid");

            migrationBuilder.CreateIndex(
                name: "ix_tracks_owner_uid",
                table: "tracks",
                column: "owner_uid");

            migrationBuilder.CreateIndex(
                name: "ix_tracks_rating_uid",
                table: "tracks",
                column: "rating_uid");

            migrationBuilder.AddForeignKey(
                name: "fk_viewed_bands_accounts_band_uid",
                table: "action_records",
                column: "band_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_viewed_bands_accounts_place_uid",
                table: "action_records",
                column: "place_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_accounts_band_uid",
                table: "live_performances",
                column: "band_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_live_performances_accounts_place_uid",
                table: "live_performances",
                column: "place_uid",
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
                name: "fk_locations_accounts_place_uid",
                table: "locations",
                column: "place_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_music_styles_accounts_band_uid",
                table: "music_styles",
                column: "band_uid",
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
                name: "fk_photos_accounts_band_uid",
                table: "resources",
                column: "band_uid",
                principalTable: "accounts",
                principalColumn: "uid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_accounts_contacts_contact_uid",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "fk_accounts_contacts_contact_uid1",
                table: "accounts");

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
                name: "music_styles");

            migrationBuilder.DropTable(
                name: "friendly_charges");

            migrationBuilder.DropTable(
                name: "tracks");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "locations");

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
