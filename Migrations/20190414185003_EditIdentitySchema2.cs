using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubEquitation.Migrations
{
    public partial class EditIdentitySchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lieu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Capacite = table.Column<int>(nullable: false),
                    Descriptif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Descriptif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cheval",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProprietaireId = table.Column<string>(nullable: true),
                    RaceId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Descriptif = table.Column<string>(nullable: true),
                    Commentaire = table.Column<string>(nullable: true),
                    NbHeureMaxSemaine = table.Column<int>(nullable: false),
                    Taille = table.Column<int>(nullable: false),
                    SearchString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cheval_AspNetUsers_ProprietaireId",
                        column: x => x.ProprietaireId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cheval_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfesseurId = table.Column<string>(nullable: true),
                    LieuId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Commentaire = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Duree = table.Column<int>(nullable: false),
                    Capacite = table.Column<int>(nullable: false),
                    EstActive = table.Column<bool>(nullable: false),
                    SearchString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activite_Lieu_LieuId",
                        column: x => x.LieuId,
                        principalTable: "Lieu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activite_AspNetUsers_ProfesseurId",
                        column: x => x.ProfesseurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activite_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChevalActivite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChevalId = table.Column<int>(nullable: false),
                    ActiviteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChevalActivite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChevalActivite_Activite_ActiviteId",
                        column: x => x.ActiviteId,
                        principalTable: "Activite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChevalActivite_Cheval_ChevalId",
                        column: x => x.ChevalId,
                        principalTable: "Cheval",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    NbPersonne = table.Column<int>(nullable: false),
                    EstActive = table.Column<bool>(nullable: false),
                    UtilisateurId = table.Column<string>(nullable: true),
                    ActiviteId = table.Column<int>(nullable: false),
                    SearchString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Activite_ActiviteId",
                        column: x => x.ActiviteId,
                        principalTable: "Activite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_AspNetUsers_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activite_LieuId",
                table: "Activite",
                column: "LieuId");

            migrationBuilder.CreateIndex(
                name: "IX_Activite_ProfesseurId",
                table: "Activite",
                column: "ProfesseurId");

            migrationBuilder.CreateIndex(
                name: "IX_Activite_TypeId",
                table: "Activite",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheval_ProprietaireId",
                table: "Cheval",
                column: "ProprietaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheval_RaceId",
                table: "Cheval",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChevalActivite_ActiviteId",
                table: "ChevalActivite",
                column: "ActiviteId");

            migrationBuilder.CreateIndex(
                name: "IX_ChevalActivite_ChevalId",
                table: "ChevalActivite",
                column: "ChevalId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ActiviteId",
                table: "Reservation",
                column: "ActiviteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UtilisateurId",
                table: "Reservation",
                column: "UtilisateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChevalActivite");

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
                name: "Type");
        }
    }
}
