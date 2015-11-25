using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Repository
{
    class BoardRepository:ICrud<DomainModelBoard>
    {
        public List<DomainModelBoard> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelBoard> boardList = context.Set<DomainModelBoard>().ToList();
                return boardList;
            }
        }

        public DomainModelBoard Read(int Id)
        {
            DomainModelBoard board = null;
            using (var context = new Context.Context())
            {
                board =
                    context.Set<DomainModelBoard>().Where(domainModelBoard => domainModelBoard.ID == Id).FirstOrDefault();
            }
            return board;
        }

        public void Create(DomainModelBoard entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelBoard>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelBoard board =
                    context.Set<DomainModelBoard>().Where(domainModelBoard => domainModelBoard.ID == Id).FirstOrDefault();
                if (board != null)
                {
                    context.Set<DomainModelBoard>().Remove(board);
                }
                context.SaveChanges();
            }
        }

        public DomainModelBoard Update(DomainModelBoard entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelBoard board =
                    context.Set<DomainModelBoard>()
                        .Where(domainModelBoard => domainModelBoard.ID == entity.ID)
                        .FirstOrDefault();
                if (board != null)
                {
                    board.Board = entity.Board;
                }
                context.SaveChanges();
                return board;
            }
        }
    }
}
