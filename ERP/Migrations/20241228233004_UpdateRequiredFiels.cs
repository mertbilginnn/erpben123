using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRequiredFiels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMWCMHEAD_CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_MATDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMBOMHEAD_MATDOCNUM",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.AlterColumn<double>(
                name: "WORKTIME",
                table: "BSMGRNNMWCMHEAD",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMWCMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMWCMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMWCM001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMROT001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMOPR001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "STUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<double>(
                name: "NETWEIGHT",
                table: "BSMGRNNMMATHEAD",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ISROUTE",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISBOM",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<double>(
                name: "BRUTWEIGHT",
                table: "BSMGRNNMMATHEAD",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMMAT001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MAINUNITCODE",
                table: "BSMGRNNMGEN005",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<int>(
                name: "ISMAINUNIT",
                table: "BSMGRNNMGEN005",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "COUNTRYCODE",
                table: "BSMGRNNMGEN004",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COUNTRYCODE",
                table: "BSMGRNNMGEN001",
                type: "nvarchar(4)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AlterColumn<string>(
                name: "ADRESS1",
                table: "BSMGRNNMGEN001",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMCCMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMCCMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMCCM001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMBOMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMBOMHEAD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DRAWNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMBOM001",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCTYPE",
                principalTable: "BSMGRNNMMAT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCTYPE",
                principalTable: "BSMGRNNMMAT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCM001_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCTYPE",
                principalTable: "BSMGRNNMWCM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCM001_CCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCTYPE",
                principalTable: "BSMGRNNMCCM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCM001_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCM001_CCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.AlterColumn<double>(
                name: "WORKTIME",
                table: "BSMGRNNMWCMHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMWCMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMWCMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMWCM001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMROT001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMOPR001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "STUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NETWEIGHT",
                table: "BSMGRNNMMATHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISROUTE",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISBOM",
                table: "BSMGRNNMMATHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BRUTWEIGHT",
                table: "BSMGRNNMMATHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(25)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(25)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMMAT001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MAINUNITCODE",
                table: "BSMGRNNMGEN005",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISMAINUNIT",
                table: "BSMGRNNMGEN005",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COUNTRYCODE",
                table: "BSMGRNNMGEN004",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "COUNTRYCODE",
                table: "BSMGRNNMGEN001",
                type: "nvarchar(4)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ADRESS1",
                table: "BSMGRNNMGEN001",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMCCMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMCCMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMCCM001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMBOMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISDELETED",
                table: "BSMGRNNMBOMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DRAWNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ISPASSIVE",
                table: "BSMGRNNMBOM001",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_MATDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMHEAD_MATDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCNUM");

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCNUM",
                principalTable: "BSMGRNNMMATHEAD",
                principalColumn: "MATDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCTYPE",
                principalTable: "BSMGRNNMMATHEAD",
                principalColumn: "MATDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCNUM",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCNUM",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCNUM",
                principalTable: "BSMGRNNMMATHEAD",
                principalColumn: "MATDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCTYPE",
                principalTable: "BSMGRNNMMATHEAD",
                principalColumn: "MATDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCNUM",
                principalTable: "BSMGRNNMWCMHEAD",
                principalColumn: "WCMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCTYPE",
                principalTable: "BSMGRNNMWCMHEAD",
                principalColumn: "WCMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCNUM",
                principalTable: "BSMGRNNMCCMHEAD",
                principalColumn: "CCMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCTYPE",
                principalTable: "BSMGRNNMCCMHEAD",
                principalColumn: "CCMDOCNUM",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
