using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataTransferObjects.DTO
{
    public class BoardDtoConverter : AbstractDtoConverter<DomainModelBoard, BoardDto>
    {
        public override BoardDto Convert(DomainModelBoard domainModelBoard)
        {
            var dto = new BoardDto()
            {
                Id = domainModelBoard.Id,
                Board = domainModelBoard.Board
            };
            return dto;
        }
    }
}
