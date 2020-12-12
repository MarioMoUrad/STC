using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQ : ContentPage
    {
        public FAQ()
        {
            InitializeComponent();
            var faqs = new List<Models.FAQsModel>();


            faqs.Add(new Models.FAQsModel()
            {
                Question = "What Papers Do you need ?",
                Answer = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Arrow = "UpArrow.png",
                isVisAns = true
                
            });
            faqs.Add(new Models.FAQsModel()
            {
                Question = "What papers do you need?",
                Answer = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Arrow = "DownArrow.png",
                isVisAns = false
                
            });
            faqs.Add(new Models.FAQsModel()
            {
                Question = "What papers do you need?",
                Answer = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Arrow = "DownArrow.png",
                isVisAns = false

            });
            faqs.Add(new Models.FAQsModel()
            {
                Question = "What Papers Do you need ?",
                Answer = "Lorem Ipsum is simply dummy text of the printing and typesetting industry",
                Arrow = "UpArrow.png",
                isVisAns = true

            });

            list.ItemsSource = faqs ; 
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}