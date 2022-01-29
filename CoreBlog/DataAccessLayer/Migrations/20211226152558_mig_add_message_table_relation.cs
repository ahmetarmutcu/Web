using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_message_table_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterOtherPassword",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OtherMessages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherMessages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_OtherMessages_Writers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherMessages_Writers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtherMessages_ReceiverID",
                table: "OtherMessages",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherMessages_SenderID",
                table: "OtherMessages",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtherMessages");

            migrationBuilder.DropColumn(
                name: "WriterOtherPassword",
                table: "Writers");
        }
    }
}
