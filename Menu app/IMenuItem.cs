
namespace Menu_app
{
    interface IMenuItem
    {
        string Title { get; set; }
        void Select();
        void Start();
    }
}
