using Firebird3Demo.DAO;
using Firebird3Demo.DTO;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Firebird3Demo.BLL
{
    /// <summary>
    /// Fiz essa classe apenas pra te mostrar a criação da transação com firebird 3 e entity core
    /// </summary>
    public class Teste_BLL 
    {
        private FbContext fb = new FbContext();

        /// <summary>
        /// Busca uma lista de pessoas com transação ReadUncommited
        /// Mais sobre transações você encontrada em: https://docs.microsoft.com/pt-br/ef/core/saving/transactions
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> GetPessoas()
        {
            try
            {
                using (var transaction = fb.Database.BeginTransaction())
                {
                        var pessoas = fb.Pessoa.ToList();

                    transaction.Rollback();

                    return pessoas;
                }
            }
            catch (Exception E)
            {
                throw new Exception("GetPessoas", E);
            }
        }

        /// <summary>
        /// Insere uma lista de pessoas com transação ReadCommited
        /// </summary>
        /// <param name="pessoas"></param>
        public int InserePessoas(List<Pessoa> pessoas)
        {
            try
            {
                using (var transaction = fb.Database.BeginTransaction())
                {
                    fb.Pessoa.AddRange(pessoas);
                    int ret = fb.SaveChanges();

                    transaction.Commit();

                    return ret;
                }
            }
            catch (Exception E)
            {
                throw new Exception("GetPessoas", E);
            }
        }

    }
}
