using Microsoft.EntityFrameworkCore.Migrations;

namespace Chart_in_Core.Migrations
{
    public partial class Empty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE proc[dbo].[Sp_GetSellerProducts] @UserName nvarchar(20)
                        as
                            select p.Id,p.Name,sp.Inventory from Users u
                            inner join Sellers s on s.UserId = u.Id
                            inner join SellerProducts sp on s.Id = sp.SellerId
                            inner join Products p on p.Id = sp.ProductId
                            where u.UserName = @UserName and sp.IsDeleted = 'False'";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
