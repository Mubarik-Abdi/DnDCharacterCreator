using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDCharacterCreator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Background_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Background_name = table.Column<string>(type: "TEXT", nullable: true),
                    Bonds = table.Column<string>(type: "TEXT", nullable: true),
                    Ideals = table.Column<string>(type: "TEXT", nullable: true),
                    Flaws = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Background_id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Class_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Class_Name = table.Column<string>(type: "TEXT", nullable: false),
                    Hit_die = table.Column<string>(type: "TEXT", nullable: false),
                    Save_proficiencies = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Class_id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Classes_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Artificer = table.Column<string>(type: "TEXT", nullable: false),
                    Barbarian = table.Column<string>(type: "TEXT", nullable: false),
                    Bard = table.Column<string>(type: "TEXT", nullable: false),
                    Cleric = table.Column<string>(type: "TEXT", nullable: false),
                    Druid = table.Column<string>(type: "TEXT", nullable: false),
                    Fighter = table.Column<string>(type: "TEXT", nullable: false),
                    Monk = table.Column<string>(type: "TEXT", nullable: false),
                    Paladin = table.Column<string>(type: "TEXT", nullable: false),
                    Ranger = table.Column<string>(type: "TEXT", nullable: false),
                    Rogue = table.Column<string>(type: "TEXT", nullable: false),
                    Sorcerer = table.Column<string>(type: "TEXT", nullable: false),
                    Warlock = table.Column<string>(type: "TEXT", nullable: false),
                    Wizard = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Classes_id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Detail_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Height = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<string>(type: "TEXT", nullable: false),
                    Eyes = table.Column<string>(type: "TEXT", nullable: false),
                    Skin = table.Column<string>(type: "TEXT", nullable: false),
                    Hair = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Detail_id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Character_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Platinum = table.Column<int>(type: "INTEGER", nullable: false),
                    Gold = table.Column<int>(type: "INTEGER", nullable: false),
                    Electrum = table.Column<int>(type: "INTEGER", nullable: false),
                    Silver = table.Column<int>(type: "INTEGER", nullable: false),
                    Copper = table.Column<int>(type: "INTEGER", nullable: false),
                    Equipment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Character_id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Player_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Player_id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Race_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<string>(type: "TEXT", nullable: false),
                    Speed = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Race_id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Skill_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Skill_id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Character_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    Charisma = table.Column<int>(type: "INTEGER", nullable: false),
                    Health = table.Column<int>(type: "INTEGER", nullable: false),
                    Initiative = table.Column<int>(type: "INTEGER", nullable: false),
                    Armor_class = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Character_id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Spell_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Spell_school = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: false),
                    Casting_time = table.Column<string>(type: "TEXT", nullable: false),
                    Components = table.Column<string>(type: "TEXT", nullable: false),
                    Classes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Spell_id);
                    table.ForeignKey(
                        name: "FK_Spells_Classes_Classes",
                        column: x => x.Classes,
                        principalTable: "Classes",
                        principalColumn: "Classes_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Character_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    User_id = table.Column<long>(type: "INTEGER", nullable: false),
                    Race = table.Column<int>(type: "INTEGER", nullable: false),
                    Class = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Alignment = table.Column<string>(type: "TEXT", nullable: false),
                    Hit_point_maximum = table.Column<int>(type: "INTEGER", nullable: false),
                    Hit_point_current = table.Column<int>(type: "INTEGER", nullable: false),
                    Background = table.Column<int>(type: "INTEGER", nullable: false),
                    EXP = table.Column<int>(type: "INTEGER", nullable: false),
                    Inventory = table.Column<int>(type: "INTEGER", nullable: false),
                    Stats = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Languages = table.Column<string>(type: "TEXT", nullable: false),
                    Skills = table.Column<int>(type: "INTEGER", nullable: false),
                    Proficiency_bonus = table.Column<int>(type: "INTEGER", nullable: false),
                    Hit_dice_total = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Character_id);
                    table.ForeignKey(
                        name: "FK_Characters_Backgrounds_Background",
                        column: x => x.Background,
                        principalTable: "Backgrounds",
                        principalColumn: "Background_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Class_Class",
                        column: x => x.Class,
                        principalTable: "Class",
                        principalColumn: "Class_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Details_Description",
                        column: x => x.Description,
                        principalTable: "Details",
                        principalColumn: "Detail_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Inventories_Inventory",
                        column: x => x.Inventory,
                        principalTable: "Inventories",
                        principalColumn: "Character_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_Race",
                        column: x => x.Race,
                        principalTable: "Races",
                        principalColumn: "Race_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Skills_Skills",
                        column: x => x.Skills,
                        principalTable: "Skills",
                        principalColumn: "Skill_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Stats_Stats",
                        column: x => x.Stats,
                        principalTable: "Stats",
                        principalColumn: "Character_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Background",
                table: "Characters",
                column: "Background");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Class",
                table: "Characters",
                column: "Class");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Description",
                table: "Characters",
                column: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Inventory",
                table: "Characters",
                column: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Race",
                table: "Characters",
                column: "Race");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Skills",
                table: "Characters",
                column: "Skills");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Stats",
                table: "Characters",
                column: "Stats");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_Classes",
                table: "Spells",
                column: "Classes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
