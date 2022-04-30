using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Migrations
{
    public partial class sp_PasswordValidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
               
            migrationBuilder.Sql(@"               
                CREATE PROCEDURE sp_PasswordValidate( 
                @ResetComparePasswordId int,      
                @ResetComparePWemail VARCHAR(255),
                @ResetCompareCode VARCHAR(255))
                AS 
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
                BEGIN
		        delete from [Identity_35_SGL_FINAL].[dbo].[AspNetUsers] 
                    where email = @ResetComparePWemail;
                delete from [Northwind_35_SGL_FINAL].[dbo].[Customers] 
                    where email = @ResetComparePWemail;
			    delete from [Northwind_35_SGL_FINAL].[dbo].[ResetPasswords] 
                    where ResetPWemail = @ResetComparePWemail; 
			    delete from [Northwind_35_SGL_FINAL].[dbo].[ResetComparePasswords] 
                    where ResetComparePWemail = @ResetComparePWemail; 
            END");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql(@"DROP PROCEDURE [dbo].[sp_PasswordValidate]");
        }
    }
}

