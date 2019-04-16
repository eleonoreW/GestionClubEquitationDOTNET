using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubEquitation.Migrations.BDClubEquitation
{
    public partial class EditIdentitySchema3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClubEquitationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Prenom = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubEquitationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lieu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Capacite = table.Column<int>(nullable: false),
                    Descriptif = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Descriptif = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cheval",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProprietaireID = table.Column<string>(nullable: true),
                    RaceID = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "date", nullable: false),
                    Descriptif = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Commentaire = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    NbHeureMaxSemaine = table.Column<int>(nullable: false),
                    Taille = table.Column<int>(nullable: false),
                    SearchString = table.Column<string>(unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheval", x => x.ID);
                    table.ForeignKey(
                        name: "Cheval_FK_Proprietaire",
                        column: x => x.ProprietaireID,
                        principalTable: "ClubEquitationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Cheval_FK_Race",
                        column: x => x.RaceID,
                        principalTable: "Race",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activite",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfesseurID = table.Column<string>(nullable: true),
                    LieuID = table.Column<int>(nullable: false),
                    TypeID = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Commentaire = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Details = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Duree = table.Column<int>(nullable: false),
                    Capacite = table.Column<int>(nullable: false),
                    EstActive = table.Column<bool>(nullable: false),
                    SearchString = table.Column<string>(unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activite", x => x.ID);
                    table.ForeignKey(
                        name: "Activite_FK_Lieu",
                        column: x => x.LieuID,
                        principalTable: "Lieu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Activite_FK_Professeur",
                        column: x => x.ProfesseurID,
                        principalTable: "ClubEquitationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Activite_FK_Type",
                        column: x => x.TypeID,
                        principalTable: "Type",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cheval_Activite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ChevalID = table.Column<int>(nullable: false),
                    ActiviteID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheval_Activite", x => new { x.ChevalID, x.ActiviteID });
                    table.ForeignKey(
                        name: "ChevalActivite_FK_Activite",
                        column: x => x.ActiviteID,
                        principalTable: "Activite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ChevalActivite_FK_Cheval",
                        column: x => x.ChevalID,
                        principalTable: "Cheval",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    NbPersonne = table.Column<int>(nullable: false),
                    EstActive = table.Column<bool>(nullable: false),
                    UtilisateurID = table.Column<string>(nullable: true),
                    ActiviteID = table.Column<int>(nullable: false),
                    SearchString = table.Column<string>(unicode: false, maxLength: 255, nullable: true, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                    table.ForeignKey(
                        name: "Reservation_FK_Activite",
                        column: x => x.ActiviteID,
                        principalTable: "Activite",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Reservation_FK_Utilisateur",
                        column: x => x.UtilisateurID,
                        principalTable: "ClubEquitationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activite_LieuID",
                table: "Activite",
                column: "LieuID");

            migrationBuilder.CreateIndex(
                name: "IX_Activite_ProfesseurID",
                table: "Activite",
                column: "ProfesseurID");

            migrationBuilder.CreateIndex(
                name: "IX_Activite_TypeID",
                table: "Activite",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "UQ__Cheval__C7D1C61EF6582795",
                table: "Cheval",
                column: "Nom",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cheval_ProprietaireID",
                table: "Cheval",
                column: "ProprietaireID");

            migrationBuilder.CreateIndex(
                name: "IX_Cheval_RaceID",
                table: "Cheval",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Cheval_Activite_ActiviteID",
                table: "Cheval_Activite",
                column: "ActiviteID");

            migrationBuilder.CreateIndex(
                name: "UQ__Lieu__C7D1C61EE3386B39",
                table: "Lieu",
                column: "Nom",
                unique: true,
                filter: "[Nom] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Race__C7D1C61E5906D50C",
                table: "Race",
                column: "Nom",
                unique: true,
                filter: "[Nom] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ActiviteID",
                table: "Reservation",
                column: "ActiviteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UtilisateurID",
                table: "Reservation",
                column: "UtilisateurID");

            migrationBuilder.CreateIndex(
                name: "UQ__Type__C7D1C61E3790728B",
                table: "Type",
                column: "Nom",
                unique: true,
                filter: "[Nom] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cheval_Activite");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Cheval");

            migrationBuilder.DropTable(
                name: "Activite");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Lieu");

            migrationBuilder.DropTable(
                name: "ClubEquitationUser");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
