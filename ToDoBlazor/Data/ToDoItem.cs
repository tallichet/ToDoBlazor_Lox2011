namespace ToDoBlazor.Data
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string DisplayLabel { get; set; } = string.Empty;

        public bool Done { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
