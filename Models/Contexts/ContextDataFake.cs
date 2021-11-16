using Kuarasy.Models.Dtos;
using System;
using System.Collections.Generic;
using Kuarasy.Models.Contracts.Context;
using System.Linq;

namespace Kuarasy.Models.Contexts
{
    public class ContextDataFake : IContextData
    {
        private static List<LivroDto> livros;

        public ContextDataFake()
        {
            livros = new List<LivroDto>();
            InitializeData();
        }

        public void AtualizarLivro(LivroDto livro)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(livro.Id);
                livros.Remove(objPesquisa);

                objPesquisa.Nome = livro.Nome;
                objPesquisa.Editora = livro.Editora;
                objPesquisa.Autor = livro.Autor;

                CadastrarLivro(objPesquisa);

            }
            catch(Exception ex)
            {
                throw ex;

            }
  
        }

        public void CadastrarLivro(LivroDto livro)
        {
            try 
            {
                livros.Add(livro);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirLivro(string id)
        {
            try
            {
                var objPesquisa = PesquisarLivroPorId(id);
                livros.Remove(objPesquisa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroDto> ListarLivro()
        {
            try
            {
                return livros.OrderBy(p => p.Nome).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LivroDto PesquisarLivroPorId(string id)
        {
            try
            {
                return livros.FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InitializeData()
        {
            var livro = new LivroDto("Harry Potter", "Kaiky", "Soft");
            livros.Add(livro);

            var livro1 = new LivroDto("Naruto", "Erikc", "Soft1");
            livros.Add(livro1);

            var livro2 = new LivroDto("Senhor do aneis", "Fernandes", "Soft2");
            livros.Add(livro2);

            var livro3 = new LivroDto("Coraline", "Olaior", "Soft3");
            livros.Add(livro3);

            var livro4 = new LivroDto("Cronicas", "roialo", "Soft4");
            livros.Add(livro4);
        }
    }

}