using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Crawler
{
    public partial class Form1 : Form
    {
        List<Movie> Pmovies = new List<Movie>();
        string Link =  "https://www.imdb.com/chart/top";
        string Xpath = "/html/body/div[3]/div/div[2]/div[3]/div/div[1]/div/span/div/div/div[3]/table/tbody/tr[position()>0]";
        
        // /html/body/div[3]/div/div[2]/div[3]/div/div[1]/div/span/div/div/div[3]/table/tbody/tr[1]/td[2]/a
        // /html/body/div[3]/div/div[2]/div[3]/div/div[1]/div/span/div/div/div[3]/table/tbody/tr[1]/td[3]/strong
        // /html/body/div[3]/div/div[2]/div[3]/div/div[1]/div/span/div/div/div[3]/table/tbody/tr[1]/td[1]/a/img
        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }

        void LoadMovies()
        {
            var Movie_List = new List<Movie>();

            var Web = new HtmlWeb();

            var Dock = Web.Load(Link);

            var Nodes = Dock.DocumentNode.SelectNodes(Xpath);

            foreach (var Node in Nodes)
            {
                try
                {
                    var Movie = new Movie
                    {
                        Name = Node.SelectSingleNode("td[2]/a").InnerText,
                        Rating = Node.SelectSingleNode("td[3]/strong").InnerText,
                        Img = Node.SelectSingleNode("td[1]/a/img").Attributes["src"].Value
                        
                    };
                    Movie_List.Add(Movie);
                }
                catch (Exception)
                {

                    throw;
                }              
            }

            foreach (var Movie in Movie_List)
            {
                dataGridView1.Rows.Add(Movie.Name, Movie.Rating);
            }

            Pmovies.Clear();
            Pmovies.AddRange(Movie_List);


        }
        class Movie
        {
            public string Name { get; set; }
            public string Rating { get; set; }

            public string Img { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = Pmovies[dataGridView1.CurrentCell.RowIndex].Img;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
