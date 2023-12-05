using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VissSoft.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1415), "Images/Course/course-1.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1440), "Images/Course/course-2.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1441), "Images/Course/course-1.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1442), "Images/Course/course-2.png" });

            migrationBuilder.UpdateData(
                table: "intro",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1576), "Images/NewAndEvent/news-1.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1578), "Images/NewAndEvent/news-2.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1579), "Images/NewAndEvent/news-3.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1611), "Images/NewAndEvent/news-4.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1626), "Images/Slide/heroes-1.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1628), "Images/Slide/heroes-2.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1629), "Images/Slide/heroes-3.png" });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "Images/Teacher/teacher-1.png", new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "Images/Teacher/teacher-2.png", new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "Images/Teacher/teacher-3.png", new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "Images/Teacher/teacher-4.png", new DateTime(2023, 12, 5, 16, 46, 38, 64, DateTimeKind.Local).AddTicks(1646) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(2993), "course-1.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3014), "course-2.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3016), "course-1.png" });

            migrationBuilder.UpdateData(
                table: "course",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3017), "course-2.png" });

            migrationBuilder.UpdateData(
                table: "intro",
                keyColumn: "id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3148), "news-1.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3150), "news-2.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3151), "news-3.png" });

            migrationBuilder.UpdateData(
                table: "newAndEvent",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3152), "news-4.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3169), "heroes-1.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3170), "heroes-2.png" });

            migrationBuilder.UpdateData(
                table: "slide",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "imgLink" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3171), "heroes-3.png" });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "teacher-1.png", new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "teacher-2.png", new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "teacher-3.png", new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "teacher",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "avatar", "created_at" },
                values: new object[] { "teacher-4.png", new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3186) });
        }
    }
}
