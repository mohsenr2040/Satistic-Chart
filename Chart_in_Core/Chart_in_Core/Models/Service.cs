using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Models
{
    public partial class Service : IService
    {
        private readonly DataBaseContext _context;
        public Service(DataBaseContext context)
        {
            _context = context;
        }

        public List<ProductDetailsDto> GetDetails(string id)
        {
            List<ProductDetailsDto> Lst_Result = new List<ProductDetailsDto>();

            using (var command = this._context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Sp_GetProductDetails";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var parameter = new SqlParameter("@ProductId", id);
                command.Parameters.Add(parameter);

                this._context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        ProductDetailsDto spdto = new ProductDetailsDto();
                        spdto.Id = result.GetInt32(result.GetOrdinal("Id"));
                        spdto.Name = result.GetString(result.GetOrdinal("Name"));
                        spdto.Brand = result.GetString(result.GetOrdinal("Brand"));
                        spdto.Price = result.GetInt32(result.GetOrdinal("Price"));
                        spdto.ViewCount = result.GetInt32(result.GetOrdinal("ViewCount"));
                        Lst_Result.Add(spdto);
                    }
                }
            }
            return Lst_Result;
        }

        public async Task<List<SellerProductsDto>> lookup(string ncode)
        {
            if (ncode == null)
                return null;
            List<SellerProductsDto> Lst_Result = new List<SellerProductsDto>();
            //var result1= _context.Database.ExecuteSqlRaw("Sp_GetSellerProducts @p0",  parameters: ncode);
            using (var command = this._context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Sp_GetSellerProducts";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var parameter = new SqlParameter("@UserName", ncode);
                command.Parameters.Add(parameter);

                this._context.Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        SellerProductsDto spdto = new SellerProductsDto();
                        spdto.ProductId = result.GetInt32(result.GetOrdinal("Id"));
                        spdto.Name = result.GetString(result.GetOrdinal("Name"));
                        spdto.inventory = result.GetInt32(result.GetOrdinal("Inventory"));
                        Lst_Result.Add(spdto);
                    }
                }
            }
            return  Lst_Result;
        }

       
      
    }
}
