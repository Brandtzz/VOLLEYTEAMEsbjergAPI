using DataAccessLayer;
using DataAccessLayer.DomainModel;
using DataTransferObjects.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rest_Api.Controllers
{
    public class BoardApiController : ApiController
    {
        Facade facade = new Facade();

        // GET: api/BoardApi
        public IEnumerable<BoardDto> GetBoards()
        {
            var boards = new Facade().GetBoardRepository().ReadAll();
            return new BoardDtoConverter().Convert(boards);
        }

        // GET: api/BoardApi/5
        public BoardDto GetBoard(int id)
        {
            var board = new Facade().GetBoardRepository().Read(id);
            return new BoardDtoConverter().Convert(board);
        }

        // POST: api/BoardApi
        public void PostBoard(DomainModelBoard domainModelBoard)
        {
            new Facade().GetBoardRepository().Create(domainModelBoard);    
        }

        // PUT: api/BoardApi/5
        public BoardDto PutBoard(DomainModelBoard domainModelBoard)
        {
            var board = new Facade().GetBoardRepository().Update(domainModelBoard);
            return new BoardDtoConverter().Convert(board);
        }

        // DELETE: api/BoardApi/5
        public void DeleteBoard(int id)
        {
            new Facade().GetBoardRepository().Delete(id);
        }
    }
}
