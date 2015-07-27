using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Game abydabi;
        public MainPage()
        {
            this.InitializeComponent();
            abydabi= new Game();
            creatUI();
            


            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        private void creatUI()
        {
           
            for (int i=0;i<3;i++)
            {
                for(int g=0;g<3;g++)
                {
                    
                    //Добавим элемент Image в первую строку элемента newGrid.
                    Image imgForPast = new Image();
                    imgForPast.Tag=i+" "+g;
                    imgForPast.Tapped += Image_Click;
                    newGrid.Children.Add(imgForPast);
                    imgForPast.Opacity = 0;
                    //Создадим экземпляр класса BitmapImage, пропишем ему путь к ресурсу с картинкой, и установим режим создания BitmapImage.
                    imgForPast.Source = new BitmapImage(new Uri(imgForPast.BaseUri, "/Resource/unnamed.png")) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };

                    Grid.SetRow(imgForPast, i);
                    Grid.SetColumn(imgForPast, g);
                   
                }
            }
        }

         private void cleanUI()
        {           
            for (int i = 0; i < newGrid.Children.Count; i++) 
            {
                Image item= newGrid.Children[i] as Image;
                if (item!=null)
                {
                    item.Opacity =0;
                }
            }
        }
         void Image_Click(object sender, TappedRoutedEventArgs e)
         {



             Image item = sender as Image;//TODO передача в core в массив координат
             item.Opacity = 1;
             item.Source = new BitmapImage(new Uri(item.BaseUri, abydabi.uri())) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };
             switch (abydabi.goMove(item.Tag.ToString()))
             {
                 case 1:
                     var messageDialog1 = new MessageDialog("Win-1");
                     messageDialog1.ShowAsync();
                     return;
                 case 2:
                     var messageDialog2 = new MessageDialog("Win-2");
                     messageDialog2.ShowAsync();
                     return;
                 case 3:
                     var messageDialog3 = new MessageDialog("Ничья");
                     messageDialog3.ShowAsync();
                     return;
             }
         }

         private void Button_Click(object sender, RoutedEventArgs e)
         {
             Core.cleanPole();
             cleanUI();
         }
    }
}
