using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlickrNet;

namespace MacGourmetReader
{
    public partial class MacGourmetReader : Form
    {
        public MacGourmetReader()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
                                     {
                                         Filter = "MacGourmet Databases (*.mgdb)|*.mgdb|All files (*.*)|*.*"
                                     };


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileNameTB.Text = dlg.FileName;
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fileNameTB.Text))
                return;
            if (!File.Exists(fileNameTB.Text))
                return;

            recipeLB.Items.Clear();

            string connectionString = String.Format("Data Source={0};", fileNameTB.Text);
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            SQLiteCommand findRecipeNames = connection.CreateCommand();

            if (String.IsNullOrEmpty(filterTB.Text))
                findRecipeNames.CommandText = "select recipe_id, name from recipe order by name";
            else
            {
                findRecipeNames.CommandText =
                    String.Format("select recipe_id, name from recipe where name like '%{0}%' order by name",
                                  filterTB.Text);
            }
            SQLiteDataReader reader = findRecipeNames.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    recipeLB.Items.Add(new Recipe
                    {
                        recipeID = reader.GetInt16(0),
                        recipeName = reader.GetString(1)
                    });
                }
            }
            reader.Close();
            connection.Close();
        }

        Flickr flickr = new Flickr("c8d3216ea1ae6748898b504bfd6230b4", "2fe4e9f5632f86d5");
            
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(flickrTB.Text))
                return;

            PhotoInfo photoInfo = flickr.PhotosGetInfo(flickrTB.Text);
            string imgUrl = photoInfo.MediumUrl;
            string linkURL = photoInfo.WebUrl;


        }
    }
}
