
namespace Menu_app
{
    internal class InfiniteMenu:IInfiniteMenu
    {
        public InfiniteMenu(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
        public void Spawn()
        {
            
        }

    }
}
