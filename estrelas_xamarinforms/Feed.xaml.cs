using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySqlConnector;

namespace AppEnsalamento
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feed : Rg.Plugins.Popup.Pages.PopupPage
	{
        public int star { get; set; }
        public string feed { get; set; }
        public int estrelas { get; set; }
        public List<int> indexes;
        public List<int> currentIndexes;

        static string con = @"server=senaisgr.com.br;port=3306;database=senais88_inventario;user id=senais88_inventario;password=C@margo2023;charset=utf8";
        public Feed ()
		{
			InitializeComponent ();
            Reset();
            indexes = new List<int>();
            currentIndexes = new List<int>();
        }

        private void Sair_Clicked(object sender, EventArgs e)
        {
			PopupNavigation.Instance.PopAsync();
        }

        void Reset()
        {
            ChangeTextColor(5, Color.Gray);
        }

        void ChangeTextColor(int starcount, Color color)
        {
            for (int i = 1; i <= starcount; i++)
            {
                (FindByName($"star{i}") as Label).TextColor = color;
                star = Convert.ToInt32(i);
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Reset();
            Label clicked = sender as Label;
            ChangeTextColor(Convert.ToInt32(clicked.StyleId.Substring(4, 1)), Color.Yellow);
        }

        private void edtFeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            errorMessage.IsVisible = false;
            Editor c = ((Editor)sender);
            int numOfNextLines = (c.Text).Split('\n').Length;
            string text = c.Text;
            textCounter.Text = text.Length.ToString();

            if (numOfNextLines < 5)
            {
                string addedText = text.Split('\n').Last();
                if (addedText.Length > 35)
                {
                    if (string.IsNullOrWhiteSpace((text.Last()).ToString()))
                    {
                        if (numOfNextLines < 4)
                            c.Text += "\n";
                        else
                        {
                            c.Text = e.OldTextValue;
                            errorMessage.Text = "Reached 4 lines";
                            errorMessage.IsVisible = true;
                        }
                    }
                    else
                    {
                        currentIndexes.Add(c.Text.Length - 1);
                        int lastIdx = text.LastIndexOf(" ");
                        if (lastIdx != -1)
                        {
                            text = text.Remove(lastIdx, 1);
                            c.Text = text.Insert(lastIdx, "\n");
                            indexes.Add(lastIdx);
                        }
                    }
                }
                else
                {
                    if (e.NewTextValue?.Length < e.OldTextValue?.Length && currentIndexes.Contains(c.Text.Length))
                    {
                        if (indexes.Contains(c.Text.LastIndexOf("\n")))
                        {
                            int removeIdx = c.Text.LastIndexOf("\n");
                            if (removeIdx != -1)
                            {
                                text = text.Remove(removeIdx, 1);
                                c.Text = text.Insert(removeIdx, " ");
                                indexes.Remove(removeIdx);
                            }
                        }
                    }
                }
            }
            else
            {
                c.Text = e.OldTextValue;
                errorMessage.Text = "Ultrapassou as 4 linhas.";
                errorMessage.IsVisible = true;
            }
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            try
            {
                feed = edtFeed.Text;
                string sql = "INSERT INTO feedapp(feed,estrelas) VALUES (@feed, @estrelas)";
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@feed", MySqlDbType.VarChar).Value = feed;
                        cmd.Parameters.Add("@estrelas", MySqlDbType.Int32).Value = star;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    DisplayAlert("Obrigado!", "Feedback, enviado com sucesso!", "OK");
                    PopupNavigation.Instance.PopAsync();
                }
            }
            catch (Exception er)
            {
                DisplayAlert("Erro", er.Message, "OK");
            }
        }
    }
}