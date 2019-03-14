using PCLStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace quotesWF_03
{
    public partial class Form1 : Form
    {
        IFolder LocalStorageFolder = FileSystem.Current.LocalStorage; // local storage folder

        string quotefolderName = "quotesFolder";
        string folderName = "MyFolder";
        string quoteFileName = "quotes.txt";
        string contentToSave = "This is some random stuff to save.";
        string loadedContent = "";

        public Form1()
        {
            InitializeComponent();
            Start();
            BackToQuotes();
            ShowRandomQuote();

            
        }

        async void Start()
        {
            ExistenceCheckResult QuotesDataFolderExist = await LocalStorageFolder.CheckExistsAsync(quotefolderName); // check if quote folder exist
            if (QuotesDataFolderExist != ExistenceCheckResult.FolderExists)
            {
                IFolder CraeteQuotesFolder = await LocalStorageFolder.CreateFolderAsync(quotefolderName,
                    CreationCollisionOption.OpenIfExists); // creates quotes folder in local storage .. localstorage/../quotesfolder

                IFile CreateQuotesFile = await CraeteQuotesFolder.CreateFileAsync(quoteFileName,
                    CreationCollisionOption.OpenIfExists); // creates quotes file in local storage .. localstorage /../ quotesfolder/quotes.txt

                IFolder GetQuotesDataFolder = await LocalStorageFolder.GetFolderAsync(quotefolderName); // gets folder that contains "quotes.txt"
                IFile GetQuotesFile = await GetQuotesDataFolder.GetFileAsync(quoteFileName); // gets file that contains jsonified quotes

                string preData = "{\"quoteDetails\":{\"quoteContent\":[\"I LOVE Microsoft\",\"life is like a bowl of soup and im a fork\",\"HTML is a programming language\",\"you'll have to speak up iam wearing a towel\",\"is mayonnaise an instrument\"],\"quoteAuthor\":[\"Steve Jobs\",\"Donald Trump\",\"Me last year\",\"Homer Simpson\",\"Patrick Star\"]}}";

                await GetQuotesFile.WriteAllTextAsync(preData);
            }

            if (QuotesDataFolderExist == ExistenceCheckResult.FolderExists)
            {
                // go to folder
                IFolder GetQuotesDataFolder = await LocalStorageFolder.GetFolderAsync(quotefolderName); // gets folder that contains "quotes.txt"
                IFile GetQuotesFile = await GetQuotesDataFolder.GetFileAsync(quoteFileName); // gets file that contains jsonified quotes
            }
        }

        async void ShowRandomQuote()
        {
            // access foolder, file 
            IFolder GetQuotesDataFolder = await LocalStorageFolder.GetFolderAsync(quotefolderName); // gets folder that contains "quotes.txt"
            IFile GetQuotesFile = await GetQuotesDataFolder.GetFileAsync(quoteFileName); // gets file that contains jsonified quotes

            // pick a random quote from that file 
            loadedContent = await GetQuotesFile.ReadAllTextAsync();
            //QuoteModel desirializedQuoteText = new QuoteModel();
            //desirializedQuoteText = JsonConvert.DeserializeObject<QuoteModel>(loadedContent);

            var quote = JsonConvert.DeserializeObject<QuoteModel>(loadedContent);

            // random
            Random random = new Random();
            int randomNumber = random.Next(0, quote.quoteDetails.quoteContent.Count);


            // show in text box
            quoteContentTxt.Text =$"\"{quote.quoteDetails.quoteContent[randomNumber].ToString()}\"";
            quoteAuthorTxt.Text = $"~{quote.quoteDetails.quoteAuthor[randomNumber].ToString()}";
        }

        async void AddQuote()
        {
            // access the quote folder => file
            IFolder GetQuotesDataFolder = await LocalStorageFolder.GetFolderAsync(quotefolderName); // gets folder that contains "quotes.txt"
            IFile GetQuotesFile = await GetQuotesDataFolder.GetFileAsync(quoteFileName); // gets file that contains jsonified quotes

            loadedContent = await GetQuotesFile.ReadAllTextAsync();

            var quote = JsonConvert.DeserializeObject<QuoteModel>(loadedContent);
            //quote.quoteDetails.quoteContent.Add(quoteToAddTxt.Text);
            int quotesCount = quote.quoteDetails.quoteContent.Count;

            //quote.quoteDetails.quoteContent[quotesCount + 1] = quoteToAddTxt.Text;

            //await GetQuotesFile.WriteAllTextAsync

            quote.quoteDetails.quoteContent.Add(quoteToAddTxt.Text);
            quote.quoteDetails.quoteAuthor.Add(quoteAuthorToAddTxt.Text);

            // serializing is turning into json
            // DE serializing is turning into text

            // convert quote to json => jsonifiedquotesfile, 
            var jsonifiedQuoteModel = JsonConvert.SerializeObject(quote);

            // overwrite quotes.txt with jsonifiedquotesfile
            await GetQuotesFile.WriteAllTextAsync(jsonifiedQuoteModel);

            quoteToAddTxt.Text = "";
            quoteAuthorToAddTxt.Text = "";

        }

        private void genarateButton_Click(object sender, EventArgs e)
        {
            ShowRandomQuote();
        }

        void CloseFrontPage()
        {
            pageTitle.Text = "Add New Quote";

            quoteContentTxt.Visible = false;
            quoteAuthorTxt.Visible = false;
            genarateButton.Visible = false;
            addNewQuotePageButton.Visible = false;

            quoteToAddTxt.Visible = true;
            quoteAuthorToAddTxt.Visible = true;
            addNewQuoteButton.Visible = true;
            backToQuotesButton.Visible = true;
        }

        void BackToQuotes()
        {
            pageTitle.Text = "Random Quote Machine";
            quoteContentTxt.Visible = true;
            quoteAuthorTxt.Visible = true;
            genarateButton.Visible = true;
            addNewQuotePageButton.Visible = true;

            quoteToAddTxt.Visible = false;
            quoteAuthorToAddTxt.Visible = false;
            addNewQuoteButton.Visible = false;
            backToQuotesButton.Visible = false;
        }

        private void addNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote();
            

        }

        private void addNewQuotePageButton_Click(object sender, EventArgs e)
        {
            CloseFrontPage();
        }

        private void backToQuotesButton_Click(object sender, EventArgs e)
        {
            BackToQuotes();
        }
    }
}
