using Gnostice.Core.Viewer;
using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Gnostice.Controls.Xamarin;
using Gnostice.Core.DOM;
using System.Windows.Input;
using Gnostice.Core;

namespace XamarinViewerDemo
{
    public partial class MainPage : ContentPage
    {

        #region Private Fields
        private TextSearchResult textResults;
        private TextSearchOptions textSearchOptions = TextSearchOptions.None;
        private Dictionary<string, string> predefinedRegEx;
        private DocumentViewer documentViewer;
        #endregion

        #region Bindable Properties

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(PageIndicatorText),
            typeof(string),
            typeof(MainPage),
            "Page 0 of 0");
        
        public string PageIndicatorText
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        
        public string ZoomIndicatorText
        {
            get => (string)GetValue(ZoomTextProperty);
            set => SetValue(ZoomTextProperty, value);
        }

        public static readonly BindableProperty ZoomTextProperty = BindableProperty.Create(
            nameof(ZoomIndicatorText),
            typeof(string),
            typeof(MainPage),
            "");

        #endregion

        public MainPage()
        {
            InitializeComponent();
            InitialDataBindings();

            documentViewer = new DocumentViewer();
            documentViewer.Preferences.ViewerSettings.Zoom.ZoomMode = ZoomMode.FitWidth;
            documentViewer.DocumentLoaded += DocViewerControl_DocumentLoaded;
            documentViewer.PageChanged += Viewer_PageChanged;
            documentViewer.PageCountChanged += Viewer_PageCountChanged;
            documentViewer.ZoomChanged += Viewer_ZoomChanged;
            gridLayout.Children.Add(documentViewer);
        }
        
        private async void PickFile_Clicked(object sender, EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();
            if (file != null)
            {
                InitializeIndicators();
                var fileBytes = file.DataArray;
                
                MemoryStream memStream = new MemoryStream(fileBytes);
                documentViewer.LoadDocument(memStream);
            }
        }
        
        private void TwoColButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.PageLayout.LayoutMode = PageLayoutMode.TwoPage;
        }

        private void SingleColButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.PageLayout.LayoutMode = PageLayoutMode.SinglePage;
        }
        
        private void FitWidthOptionButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.Zoom.ZoomMode = ZoomMode.FitWidth;
        }

        private void ZoomInBotton_Clicked(object sender, EventArgs e)
        {
            documentViewer.ZoomIn();
        }

        private void ZoomOutButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.ZoomOut();
        }
        
        private void RotateClockwiseButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.RotatePagesClockwise90();
        }

        private void RotateAntiClockwiseButton_Clicked(object sender, EventArgs e)
        {
            documentViewer.RotatePagesAntiClockwise90();
        }

        private void VerticalOrientationBotton_Clicked(object sender, EventArgs e)
        {
            documentViewer.Orientation = ViewerOrientation.Vertical;
        }

        private void HorizontalOrientationBotton_Clicked(object sender, EventArgs e)
        {
            documentViewer.Orientation = ViewerOrientation.Horizontal;
        }

        private void TextSearchBotton_Clicked(object sender, EventArgs e)
        {
            searchInput.TextColor = Color.Default;
            searchBarControl.IsVisible = !searchBarControl.IsVisible;
            regExSearchBarControl.IsVisible = false;
            if (searchBarControl.IsVisible)
            {
                searchInput.Focus();
            }
        }

        private void RegxSearchBotton_Clicked(object sender, EventArgs e)
        {
            searchInput.TextColor = Color.Default;
            searchBarControl.IsVisible = false;
            regExSearchBarControl.IsVisible = !regExSearchBarControl.IsVisible;
        }

        private void NextSearchBotton_Clicked(object sender, EventArgs e)
        {
            searchInput.TextColor = Color.Default;

            textResults = documentViewer.FindNext(
                searchInput.Text,
                textSearchMode:TextSearchMode.Literal, 
                searchOptions: textSearchOptions, 
                lastSearchResult: textResults
                );
            

            ValidateResults();
        }

        private void PrevSearchBotton_Clicked(object sender, EventArgs e)
        {
            searchInput.TextColor = Color.Default;
            textResults = documentViewer.FindPrevious(searchInput.Text, searchOptions: textSearchOptions, lastSearchResult: textResults);
            ValidateResults();
        }

        private void NextRegExSearchBottonClicked(object sender, EventArgs e)
        {
            string regExKey = RegExSearchPicker.SelectedItem.ToString();
            string regExString = predefinedRegEx[regExKey];
            textResults = documentViewer.FindNext(regExString, textSearchMode: TextSearchMode.Regex, lastSearchResult: textResults);
        }

        private void PrevRegExSearchBottonClicked(object sender, EventArgs e)
        {
            string regExKey = (string)RegExSearchPicker.SelectedItem;
            string regExString = predefinedRegEx[regExKey];
            textResults = documentViewer.FindPrevious(regExString, textSearchMode: TextSearchMode.Regex, lastSearchResult: textResults);
        }
        
        private void SearchBarControl_TextChanged(object sender, TextChangedEventArgs e)
        {
            textResults = null;
            searchInput.TextColor = Color.Default;
        }

        private void SeachInput_Completed(object sender, EventArgs e)
        {
            searchInput.TextColor = Color.Default;
            textResults = documentViewer.FindNext(searchInput.Text, searchOptions:textSearchOptions, lastSearchResult: textResults);
            ValidateResults();
        }

        private void ValidateResults() {
            if (textResults == null) {
                searchInput.TextColor = Color.Red;
            }
        }

        private void SearchOptionsButton_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = true;
        }

        private void OKSearchOptionDialogButton_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = false;
        }

        private void CaseSensitiveSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
                {
                    textSearchOptions |= TextSearchOptions.CaseSensitive;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.CaseSensitive))
                {
                    textSearchOptions &= ~TextSearchOptions.CaseSensitive;
                }
            }
        }

        private void WholeWordSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
                {
                    textSearchOptions |= TextSearchOptions.WholeWord;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.WholeWord))
                {
                    textSearchOptions &= ~TextSearchOptions.WholeWord;
                }
            }
        }

        private void WrapAroundSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                if (!textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
                {
                    textSearchOptions |= TextSearchOptions.WrapAround;
                }
            }
            else
            {
                if (textSearchOptions.HasFlag(TextSearchOptions.WrapAround))
                {
                    textSearchOptions &= ~TextSearchOptions.WrapAround;
                }
            }
        }

        private void DocViewerControl_DocumentLoaded(object sender, DocumentLoadedEventArgs e)
        {
            PageIndicatorText = "Page " + documentViewer.CurrentPage.ToString() + " of " + documentViewer.PageCount;
        }

        private void Viewer_ZoomChanged(object sender, ZoomChangedEventArgs e)
        {
            ZoomIndicatorText = "Zoom : " + ((int)e.ZoomPercent).ToString() + "%";
        }

        private void Viewer_PageCountChanged(object sender, Gnostice.Core.Viewer.PageCountChangedEventArgs e)
        {
            PageIndicatorText = "Page " + documentViewer.CurrentPage.ToString() + " of " + e.PageCount;
        }

        private void Viewer_PageChanged(object sender, PageChangedEventArgs e)
        {
            PageIndicatorText = "Page " + e.PageNumber.ToString() + " of " + documentViewer.PageCount;
        }

        private void InitialDataBindings()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 30, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(0, 0, 0, 0);
                    break;
            }
            string strRegex = "[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})";
            predefinedRegEx = new Dictionary<string, string>
            {
                { "Email", strRegex },
                { "SSN", @"^\d{3}-\d{2}-\d{4}$" },
                { "US Phone Number", @"^[2-9]\d{2}-\d{3}-\d{4}$" }

            };
            RegExSearchPicker.ItemsSource = predefinedRegEx.Keys.ToList();
        }

        private void InitializeIndicators()
        {
            textResults = null;
            PageIndicatorText = "Page 0 of 0";
            ZoomIndicatorText = "";
        }
    }
}
