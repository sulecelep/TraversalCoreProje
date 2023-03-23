namespace TraversalCoreProje.CQRS.Results.DestinationResults
{
    public class GetDestinationByIDQueryResult
    {
        //Güncellemek istediğimiz verilere ait değerler
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
    }
}
