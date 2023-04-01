namespace WebApi.Domain
{
    public class Todo
    {
        
        public int Id { get; init; }
        public string Title { get; init; }
        /// <summary>
        /// День, на который запланирован Todo
        /// </summary>
        public DateTime PlannedDay { get; init; }
        public Todo(int id, string title, DateTime plannedDay)
        {
            Id = id;
            Title = title;
            PlannedDay = plannedDay;
        }

        public Todo(int id, string title)
        {
            Id = id;
            Title = title;
            PlannedDay = DateTime.UtcNow;
        }
    }
}
