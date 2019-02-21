using SalesWebMvc01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc01.Services
{
    public class SellerService
    {
        // Declarando um dependênca para a classe Service o readonly faz com que a dependência não possa ser alterada.
        private readonly SalesWebMvc01Context _context;

        // Criando um constrututor para injeção de dependência possa ocorrer.
        public SellerService(SalesWebMvc01Context context)
        {
            _context = context;

            
        }

        // buscando o dados no banco e exibindo em uma lista.
        public List<Seller> FindAll()
        {

            /* Esse seria o select de todos os vendedores no bando
             * perceba que os dados são acessando no contex do seller e a função ToList() lista os dados dessa "tabela seller"
             * 
             * Detalhe essa é um operação Sincorna que deixa a consulta ainda lenta o melhor seria trabalhar com um 
             * operação assincrona.
             */
            return _context.Seller.ToList();


        }

        public void Insert(Seller obj)
        {   
            // criando o objeto 
            _context.Add(obj);
            // gravando as mudanças no banco
            _context.SaveChanges();
        }



    }
}
