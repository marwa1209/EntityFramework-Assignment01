using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Assignment01.Migrations
{
    public partial class Assignment02Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructor_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Course_Insts");

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_ID",
                table: "Students",
                column: "Dep_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructor_Inst_ID",
                table: "Course_Insts",
                column: "Inst_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students",
                column: "Dep_ID",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructor_Inst_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_ID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_ID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructor_InstructorID",
                table: "Course_Insts",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
