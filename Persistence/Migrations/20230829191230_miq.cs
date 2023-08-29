using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSite.Persistence.Migrations
{
    public partial class miq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    FuelEfficiency = table.Column<double>(type: "float", nullable: false),
                    photos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Color", "EngineSize", "FuelEfficiency", "Make", "Model", "Price", "Year", "photos" },
                values: new object[,]
                {
                    { 1, "Black", 2500, 25.800000000000001, "Ford", "Mustang", 45000, 2023, "/Images/mustang.jpg" },
                    { 2, "Yellow", 3000, 24.600000000000001, "Chevrolet", "Camaro", 42000, 2022, "/Images/camaro.jpg" },
                    { 3, "Blue", 2000, 28.5, "BMW", "3 Series", 40000, 2021, "/Images/bmw3ser.jpg" },
                    { 4, "Dark", 10000, 90.5, "Toyota", "Supra", 45000, 2012, "/Images/supra.jpg" },
                    { 5, "Silver", 2000, 30.5, "Toyota", "Camry", 25000, 2022, "" },
                    { 6, "White", 3500, 22.300000000000001, "BMW", "X5", 65000, 2023, "/Images/bmwx5jpg.jpg" },
                    { 7, "Red", 1800, 32.100000000000001, "Honda", "Accord", 28000, 2021, "/Images/HondaAccord.jpg" },
                    { 8, "Red", 5000, 20.100000000000001, "Ford", "Mustang GT", 50000, 2022, "" },
                    { 9, "White", 2500, 26.800000000000001, "Mercedes-Benz", "C-Class", 45000, 2020, "/Images/mers.jpg" },
                    { 10, "Silver", 1600, 34.200000000000003, "Hyundai", "Elantra", 28000, 2020, "/Images/elantra.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
