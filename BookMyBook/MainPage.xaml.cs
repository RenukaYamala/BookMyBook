using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookMyBook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var books = GetBooks();
            bookList.ItemsSource = books;
        }
        List<BookModel> GetBooks()
        {
            var books = new List<BookModel>();
            books.Add(new BookModel() { BookName = "Can Love Happen Twice", BookAuthor = "Ravin", BookPrice = 199, BookRating = 4 ,BookImage= "canlovehappentwice.jpeg",BookDetails= "It is difficult to forget your first love but, life never stops. This is what happened in the story of Can Love Happen Twice as well. Ravinder Singh, the author, welcomes love for the second time in his life. But, there is a big twist in his life that breaks him down again." });
            books.Add(new BookModel() { BookName = "I Too Had A Love Story", BookAuthor = "Ravin", BookPrice = 300, BookRating = 4 , BookImage = "itoohadalovestory.jpg" ,BookDetails="This is an autobiographical novel by Ravinder Singh which means this is his very own story.Ravin(Ravinder himself) and Khushi are the protagonists in the story.Both of them meet over the internet and are looking for the perfect soul mate." });
            books.Add(new BookModel() { BookName = "Your Dreams Are Mine", BookAuthor = "Ravin", BookPrice = 349.5, BookRating = 4 , BookImage = "urdreamsareminenow.jpg", BookDetails = "But their fight against evil comes at a heavy price, which becomes the ultimate test of their lives. Against the backdrop of dominant campus politics, Your Dreams Are Mine Now is an innocent love story that is bound to evoke strong emotions in your heart." });
            return books;
        }
        private async void bookList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedBook = e.SelectedItem as BookModel;
            await Navigation.PushAsync(new SelectedBookDetails(SelectedBook));
        }
    }
}
