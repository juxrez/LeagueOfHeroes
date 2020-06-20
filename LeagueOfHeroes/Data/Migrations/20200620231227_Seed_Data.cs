using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueOfHeroes.Data.Migrations
{
    public partial class Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Age", "City", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, 45, "Noxus", "Alistar", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt3b366925d2fd8fdb/5db05fa856458c6b3fc1750b/RiotX_ChampionList_alistar.jpg?quality=90&width=100" },
                    { 2, 33, "Bilgewater", "Aakali", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt80ff58fe809777ff/5db05fa8adc8656c7d24e7d6/RiotX_ChampionList_akali.jpg?quality=90&width=100" },
                    { 3, 27, "Piltover", "VI", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt3bd79abf330fc807/5db06014dc674266df3d5d56/RiotX_ChampionList_vi.jpg?quality=90&width=100" },
                    { 4, 230, "Bilgewater", "Vladimir", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt39ab5027f6fa1b81/5db0601589fb926b491ed82f/RiotX_ChampionList_vladimir.jpg?quality=90&width=100" },
                    { 5, 88, "Ionia", "Zac", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt9412083c2b98b9c8/5db0601d6af83b6d7032c910/RiotX_ChampionList_zac.jpg?quality=90&width=100" },
                    { 6, 33, "Bilgewater", "Sona", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt4810827f74fc21b9/5db06003347d1c6baa57be49/RiotX_ChampionList_sona.jpg?quality=90&width=100" },
                    { 7, 36, "Shadow Isles", "Morgana", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltc81eece55f126d2d/5db05fe86af83b6d7032c904/RiotX_ChampionList_morgana.jpg?quality=90&width=100" },
                    { 8, 1240, "Demacia", "Azir", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt0e3f847946232167/5db05fa889fb926b491ed7ff/RiotX_ChampionList_azir.jpg?quality=90&width=100" },
                    { 9, 38, "Noxus", "Draven", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/bltc0be728e4cbb8f2a/5db05fbc89fb926b491ed80b/RiotX_ChampionList_draven.jpg?quality=90&width=100" },
                    { 10, 30, "Targon", "Fiora", "https://images.contentstack.io/v3/assets/blt731acb42bb3d1659/blt935dd149b2617ac8/5db05fbcdc674266df3d5d36/RiotX_ChampionList_fiora.jpg?quality=90&width=100" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "HeroId", "RatingBy", "RatingDate", "Stars" },
                values: new object[,]
                {
                    { 1, 1, "Alvaro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, 10, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 27, 9, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, 9, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, 9, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, 8, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, 8, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, 8, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, 7, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 20, 7, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 19, 7, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 18, 6, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 17, 6, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, 6, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 15, 5, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, 5, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, 5, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, 4, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 4, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 4, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, 3, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, 3, "Maria", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 7, 3, "Tania", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 2, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 5, 2, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 2, "Alex", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 3, 1, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 2, 1, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, 10, "Ramon", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 30, 10, "Pedro", new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
