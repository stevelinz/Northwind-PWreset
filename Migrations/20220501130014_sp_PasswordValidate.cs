using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Migrations
{
    public partial class sp_PasswordValidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        var sql = @"
            IF OBJECT_ID('sp_PasswordValidate', 'P') IS NOT NULL
            DROP PROC sp_PasswordValidate
            GO                       
                CREATE PROCEDURE [dbo].[sp_PasswordValidate]                     
                @ResetComparePWemail VARCHAR(255)             
                AS
                BEGIN
                SET NOCOUNT ON;

                DELETE rp
                FROM Northwind_35_SGL_FINAL.[dbo].ResetPasswords rp 
                LEFT JOIN Northwind_35_SGL_FINAL.[dbo].ResetComparePasswords rcp 
                ON rp.ResetPWemail = rcp.ResetComparePWemail
                AND rp.ResetCode = rcp.ResetCompareCode
                WHERE rcp.ResetComparePWemail = @ResetComparePWemail;


            IF  NOT EXISTS 
                (SELECT ResetPWemail
                FROM  [Northwind_35_SGL_FINAL].[dbo].[ResetPasswords]
                WHERE  ResetPWemail = @ResetComparePWemail)                  
                delete from [Northwind_35_SGL_FINAL].[dbo].[Customers] 
                    where email = @ResetComparePWemail;
                delete from [Northwind_35_SGL_FINAL].[dbo].[ResetPasswords] 
                    where ResetPWemail = @ResetComparePWemail; 
                delete from [Northwind_35_SGL_FINAL].[dbo].[ResetComparePasswords] 
                    where ResetComparePWemail = @ResetComparePWemail; 
            END";
             migrationBuilder.Sql(sql);  
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[sp_PasswordValidate]");
        }
    }
}
