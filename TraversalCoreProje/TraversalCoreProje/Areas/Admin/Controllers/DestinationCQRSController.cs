using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIDQueryHandler _getDestinationByIDQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIDQueryHandler getDestinationByIDQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _queryHandler = queryHandler;
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _queryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestination( UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("DestinationCQRS","Admin");
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("DestinationCQRS", "Admin");
        }
        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("DestinationCQRS", "Admin");
        }
    }
}
