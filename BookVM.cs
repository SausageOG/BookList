using Prism.Commands;
using System.Collections.ObjectModel;

namespace BOOKLIST
{
    class BookVM
    {
        BookModel bookM;

        public DelegateCommand<string> AddCommand { get; private set; }
        public DelegateCommand<int?> RemoveCommand { get; private set; }
        public DelegateCommand<int?> MoveCommand { get; private set; }



        public ReadOnlyObservableCollection<string> WhishlistView => bookM.Whishlist;
        public ReadOnlyObservableCollection<string> ReadedView => bookM.Readed;

        public void Add(string value)
        {
            if(value != "")
            {
                bookM.AddToWhishlist(value);
            }
        }

        public void Move(int? index)
        {
            if (index.Value != -1)
            {
                bookM.MoveToReaded(index);
            }
            
        }
        public void Remove(int? index)
        {
            if (index.HasValue)
            {
                bookM.Remove(index.Value);
            }
        }

        public BookVM()
        {
            bookM = new BookModel();

            AddCommand = new DelegateCommand<string>(Add);
            MoveCommand = new DelegateCommand<int?>(Move);
            RemoveCommand = new DelegateCommand<int?>(Remove);
        }
    }
}
