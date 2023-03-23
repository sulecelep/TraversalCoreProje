namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
