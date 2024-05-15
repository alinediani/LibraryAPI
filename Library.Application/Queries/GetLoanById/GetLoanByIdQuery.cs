using Library.Application.ViewModels;
using MediatR;

namespace Library.Application.Queries.GetLoanById
{
    public class GetLoanByIdQuery : IRequest<LoansDetailsViewModel>
    {
        public GetLoanByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
