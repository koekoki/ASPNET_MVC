using Kuarasy.Models.Dtos;
using System.Collections.Generic;

namespace Kuarasy.Models.Contracts.Context
{
	public interface IContextData
	{
		void CadastrarLivro(LivroDto livro);
		List<LivroDto> ListarLivro();
		LivroDto PesquisarLivroPorId(string id);
		void AtualizarLivro(LivroDto livro);
		void ExcluirLivro(string id);
	}

}