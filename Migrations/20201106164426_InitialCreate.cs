using Microsoft.EntityFrameworkCore.Migrations;

namespace IDT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Additions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Addition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Template = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "Action" },
                values: new object[,]
                {
                    { 1, "create" },
                    { 20, "write down" },
                    { 19, "clear" },
                    { 18, "fix" },
                    { 17, "breack" },
                    { 16, "hack" },
                    { 14, "collect" },
                    { 13, "distribute" },
                    { 12, "predict" },
                    { 11, "count" },
                    { 15, "spam" },
                    { 9, "build" },
                    { 10, "watch" },
                    { 3, "produce" },
                    { 4, "invent" },
                    { 5, "construct" },
                    { 2, "make" },
                    { 7, "collaborate with" },
                    { 8, "calculate" },
                    { 6, "defile" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Actor" },
                values: new object[,]
                {
                    { 13, "sales managers" },
                    { 20, "art directors" },
                    { 19, "animators" },
                    { 18, "3D Modelers" },
                    { 17, "game writers" },
                    { 16, "copywriters" },
                    { 15, "project managers" },
                    { 14, "account managers" },
                    { 11, "information security specialists" },
                    { 12, "HR managers" },
                    { 9, "IoT specialists" },
                    { 10, "network administrators" },
                    { 2, "men" },
                    { 3, "devOps" },
                    { 4, "data scientists" },
                    { 1, "developers" },
                    { 6, "cloud сomputing experts" },
                    { 7, "data engineers" },
                    { 8, "fullstack-developers" },
                    { 5, "business analysts" }
                });

            migrationBuilder.InsertData(
                table: "Additions",
                columns: new[] { "Id", "Addition" },
                values: new object[,]
                {
                    { 12, "route for pizza delivery men" },
                    { 19, "potatoes in the village" },
                    { 18, "birthday scenarios" },
                    { 17, "mining of endless energy" },
                    { 16, "invisible force that cleans the house" },
                    { 15, "fun days on vacation" },
                    { 14, "discounts on aliexpress" },
                    { 20, "works of art" },
                    { 13, "circuits for electronic boards" },
                    { 11, "deadly virus distribution maps" },
                    { 7, "digital twin" },
                    { 9, "distributed data chain" },
                    { 8, "virtual reality wars" },
                    { 6, "artificial intelligence robots" },
                    { 5, "warehouses with Formula 1 cars" },
                    { 4, "skyscrapers" },
                    { 3, "puppy registration database" },
                    { 2, "calculations for the construction of an intergalactic ship" },
                    { 1, "big data analytics" },
                    { 10, "adaptive security architecture" }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Template" },
                values: new object[,]
                {
                    { 2, "Using {techStack} implement an application allowing {actor} {action} {addition}." },
                    { 1, "Implement application using {techStack} allowing {actor} {action} {addition}." },
                    { 3, "With the help of {techStack} implement an application allowing {actor} {action} {addition}." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Additions");

            migrationBuilder.DropTable(
                name: "Templates");
        }
    }
}
