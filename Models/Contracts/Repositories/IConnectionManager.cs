using Kuarasy.Models.Dtos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kuarasy.Models.Contracts.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }

}
