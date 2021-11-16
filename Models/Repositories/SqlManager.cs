using Kuarasy.Models.Dtos;
using Kuarasy.Models.Enums;
using System.Collections.Generic;

namespace Kuarasy.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql tsql)
        {
            var sql = "";

            switch(tsql)
            {
                case TSql.CADASTRAR_LIVRO:
                    sql = "insert into livro (id, nome, autor, editora) values (@id, @nome, @autor, @editora)";
                    break;

                case TSql.LISTAR_LIVRO:
                    sql = "select * from livro order by nome";
                    break;

                case TSql.PESQUISAR_LIVRO:
                    sql = "select id, nome, autor, editora from livro where id = @id";
                    break;

                case TSql.ATUALIZAR_LIVRO:
                    sql = "update livro set nome = @nome, autor = @autor, editora = @editora from livro where id = @id";
                    break;

                case TSql.EXCLUIR_LIVRO:
                    sql = "delete from livro where id = @id";
                    break;
            }

            return sql;
        }
    }

}