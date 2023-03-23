using MediatR;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDResult>
    {
        public GetGuideByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; } 
    }
}
