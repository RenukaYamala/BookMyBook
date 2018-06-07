using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookMyBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedBookDetails : ContentPage
	{
        private BookModel BookDetails { get; set; }
        public SelectedBookDetails (BookModel selectedBookDetails)
		{
			InitializeComponent ();
            BookDetails = selectedBookDetails;
            BookImageLable.Source = BookDetails.BookImage;
            BookNameLable.Text = BookDetails.BookName;
            BookAuthorLable.Text = BookDetails.BookAuthor;
            BookPriceLable.Text = BookDetails.BookPrice.ToString();
            BookRateLable.Text = BookDetails.BookRating.ToString();
            BookDetailsLable.Text = BookDetails.BookDetails;
        }
        private void BuyNow(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "NO books are available", "Ok");
        }
    }
}