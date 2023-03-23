using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Queries.GuideQueries;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery,GetGuideByIDResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIDResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
