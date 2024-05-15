using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public DeleteBookCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
