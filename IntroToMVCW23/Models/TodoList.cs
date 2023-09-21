namespace IntroToMVCW23.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public HashSet<TodoItem> Items { get; set; } = new HashSet<TodoItem>();
    }
}
