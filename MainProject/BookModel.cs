using System.Collections.ObjectModel;

namespace BOOKLIST
{
    class BookModel
    {
        private readonly ObservableCollection<string> _whishlist = new ObservableCollection<string>();
        public readonly ReadOnlyObservableCollection<string> Whishlist;

        private readonly ObservableCollection<string> _readed = new ObservableCollection<string>();
        public readonly ReadOnlyObservableCollection<string> Readed;

        public BookModel()
        {
            Whishlist = new ReadOnlyObservableCollection<string>(_whishlist);
            Readed = new ReadOnlyObservableCollection<string>(_readed);
        }


        public void AddToWhishlist(string value)
        {
            _whishlist.Add(value);
        }

        public void MoveToReaded(int? index)
        {
            string copy = _whishlist[index.Value];
            _whishlist.RemoveAt(index.Value);
            _readed.Add(copy);
        }
        public void Remove(int? index)
        {
            if (index.Value != -1)
            {
                _whishlist.RemoveAt(index.Value);
            }
            
        }
    }
}
