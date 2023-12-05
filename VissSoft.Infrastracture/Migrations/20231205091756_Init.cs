using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VissSoft.Infrastracture.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imgLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "intro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intro", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "newAndEvent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    imgLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newAndEvent", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "slide",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    imgLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slogan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slide", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "teacher",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    avatar = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: true),
                    updatedBy = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacher", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "course",
                columns: new[] { "id", "color", "createdBy", "created_at", "imgLink", "name", "status", "updatedBy", "updated_at" },
                values: new object[,]
                {
                    { 1, "#ffb74a", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(2993), "course-1.png", "Khai giảng khóa lớp 1", true, null, null },
                    { 2, "#00bc51", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3014), "course-2.png", "Khai giảng khóa lớp 2", true, null, null },
                    { 3, "#ff9679", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3016), "course-1.png", "Khai giảng khóa lớp 3", true, null, null },
                    { 4, "#1dc2da", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3017), "course-2.png", "Khai giảng khóa lớp 4", true, null, null }
                });

            migrationBuilder.InsertData(
                table: "intro",
                columns: new[] { "id", "content", "createdBy", "created_at", "status", "title", "updatedBy", "updated_at" },
                values: new object[] { 1, "Tại lớp học, các thầy cô luôn có những phương pháp giảng dạy để truyền ngọn lửa đam mê môn học cho các con, giúp khơi gợi niềm say mê học tập.", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3135), true, "Toán học SkyMath", null, null });

            migrationBuilder.InsertData(
                table: "newAndEvent",
                columns: new[] { "id", "content", "createdBy", "created_at", "imgLink", "status", "title", "updatedBy", "updated_at" },
                values: new object[,]
                {
                    { 1, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3148), "news-1.png", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh", null, null },
                    { 2, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3150), "news-2.png", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh", null, null },
                    { 3, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3151), "news-3.png", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh", null, null },
                    { 4, "Mọi thông tin về vòng thi sắp tới đây đều được cập nhật và thông báo tại đây", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3152), "news-4.png", true, "Mở vòng thi số 02 Violympic môn Toán bằng Tiếng Anh", null, null }
                });

            migrationBuilder.InsertData(
                table: "slide",
                columns: new[] { "id", "createdBy", "created_at", "imgLink", "slogan", "status", "updatedBy", "updated_at" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3169), "heroes-1.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true, null, null },
                    { 2, null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3170), "heroes-2.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true, null, null },
                    { 3, null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3171), "heroes-3.png", "Cùng SkyMath bứt phá Điểm 10 không khó", true, null, null }
                });

            migrationBuilder.InsertData(
                table: "teacher",
                columns: new[] { "id", "avatar", "createdBy", "created_at", "description", "name", "status", "updatedBy", "updated_at" },
                values: new object[,]
                {
                    { 1, "teacher-1.png", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3182), "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Thầy Nguyễn Duy Minh", true, null, null },
                    { 2, "teacher-2.png", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3183), "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Hoàng Thị Cẩm Tú", true, null, null },
                    { 3, "teacher-3.png", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3184), "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Lương Thùy Linh", true, null, null },
                    { 4, "teacher-4.png", null, new DateTime(2023, 12, 5, 16, 17, 56, 684, DateTimeKind.Local).AddTicks(3186), "Với kinh nghiệm nhiều năm trong nghề, thầy đã không chỉ giup các em học sinh trở nên yêu thích môn Toán, mà còn đạt giải cao trong các cuộc thi lớn...", "Cô Trần Mai Phương", true, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "intro");

            migrationBuilder.DropTable(
                name: "newAndEvent");

            migrationBuilder.DropTable(
                name: "slide");

            migrationBuilder.DropTable(
                name: "teacher");
        }
    }
}
