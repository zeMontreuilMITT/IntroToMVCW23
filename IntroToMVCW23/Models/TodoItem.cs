namespace IntroToMVCW23.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed {  get; set; }

        public int TodoListId {  get; set; }
        public TodoList TodoList { get; set; }

    }
}
