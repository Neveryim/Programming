using Programming.Models.Classes;
using Programming.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        //список всех перечислений
        string[] enums = { "Colors", "EducationForm", "Genre", "Menufactures", "Season", "Weekday" };

        //переменные для второй лр
        private Rectange[] _rectangles = new Rectange[5];
        private Movie[] _movie = new Movie[5];
        private Rectange _currentRenctangle = new Rectange();
        private Movie _currentMovie = new Movie();
        private string[] _colors = { "Orange", "Black", "Red", "Green", "Blue" };
        private int max = 0;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumsListBox.Items.AddRange(enums); //заполняем первый листбокс
            EnumsListBox.SetSelected(0, true); // будет выделен первый элемент
            


        }
        //организуем заполнение второго листбокса 
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();// для чистой записи 
            ListBox lb = (ListBox)sender;// создаем объект листбокса 
            string elem = lb.SelectedItem as string;// переменная для записи выбора 
            switch (elem)
            {
                case "Colors":

                    ValueListBox.Items.AddRange(typeof(Colors).GetEnumNames());// получаем весь список 
                    break;
                case "EducationForm":
                     ValueListBox.Items.AddRange(typeof(EducationForm).GetEnumNames());
                    break;
                case "Genre":
                    ValueListBox.Items.AddRange(typeof(Genre).GetEnumNames());
                    break;
                case "Season":
                    ValueListBox.Items.AddRange(typeof(Season).GetEnumNames());
                    break;
                case "Menufactures":
                    ValueListBox.Items.AddRange(typeof(Menufactures).GetEnumNames());
                    break;
                case "Weekday":
                    ValueListBox.Items.AddRange(typeof(Weekday).GetEnumNames());
                    break;
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text= ValueListBox.SelectedIndex.ToString(); // получаем нужный индекс 
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday week;//переменная перечисления 
            if (Enum.TryParse<Weekday>(ParseTexBox.Text, out week)) // условие проверки ввода пользователя 
                ParseLabel.Text = $"«Это день недели ({week} = {((int)week + 1)})»";
            else ParseLabel.Text = "Нет такого дня недели!";
        }

        private void Gobutton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString(); // получаем выбоанный объект
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Брр, ходища!");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Spring":
                    splitContainer1.Panel2.BackColor = Color.GreenYellow; // меняем цвет окна 
                    break;
                case "Autumn":
                    splitContainer1.Panel2.BackColor= Color.OrangeRed;
                    break;
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (max < _rectangles[i].getWith())
                {
                    max = _rectangles[i].getWith();
                    index = i;

                }

            }
            MessageBox.Show($"Наибольший прямоугольник с индексом - {index}");
            rect_listBox.SetSelected(index, true); // будет выделен max элемент
        }

        private void color_tb_TextChanged(object sender, EventArgs e)
        {
            if (lenght_tb.Text != "" & width_tb.Text != "" & color_tb.Text != "")
            {
                try
                {
                    color_tb.BackColor = Color.White;
                    _currentRenctangle = new Rectange(Convert.ToInt32(lenght_tb.Text), Convert.ToInt32(width_tb.Text), color_tb.Text, Convert.ToInt32(IdTextBox.Text));
                    _rectangles[(int)rect_listBox.SelectedIndex] = _currentRenctangle;// присваиваем новые значения
                }
                catch
                {
                    
                }

            }
        }

        private void width_tb_TextChanged(object sender, EventArgs e)
        {
            if (lenght_tb.Text != "" & width_tb.Text != "" & color_tb.Text != "")
            {
                try
                {
                    width_tb.BackColor = Color.White;
                    _currentRenctangle = new Rectange(Convert.ToInt32(lenght_tb.Text), Convert.ToInt32(width_tb.Text), color_tb.Text, Convert.ToInt32(IdTextBox.Text));
                    _rectangles[(int)rect_listBox.SelectedIndex] = _currentRenctangle;// присваиваем новые значения
                }
                catch
                {
                    width_tb.BackColor = Color.LightPink;
                }

            }
        }

        private void lenght_tb_TextChanged(object sender, EventArgs e)
        {
            if (lenght_tb.Text != "" & width_tb.Text != "" & color_tb.Text != "")//проверка на то что поле не нулевое 
            {
                try
                {
                    lenght_tb.BackColor = Color.White;
                    _currentRenctangle = new Rectange(Convert.ToInt32(lenght_tb.Text), Convert.ToInt32(width_tb.Text), color_tb.Text, Convert.ToInt32(IdTextBox.Text));
                    _rectangles[(int)rect_listBox.SelectedIndex] = _currentRenctangle;// присваиваем новые значения
                }
                catch
                {
                    lenght_tb.BackColor = Color.LightPink;
                }

            }
        }

        private void rect_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRenctangle = null;
            _currentRenctangle = _rectangles[(int)rect_listBox.SelectedIndex];
            //Получаем данные о выбранном объекте 
            string[] answr = _currentRenctangle.answRec();
            lenght_tb.Text = answr[0];
            width_tb.Text = answr[1];
            color_tb.Text = answr[2];
            Point2D ct = _rectangles[rect_listBox.SelectedIndex].Center();
            CentertextBox.Text = ct.PrintCenter();
            IdTextBox.Text = answr[3];
           
        }

        private void Find_movie_button_Click(object sender, EventArgs e)
        {
            max = 0;
            int index = 0;
            for (int i = 0; i < _movie.Length; i++)
            {
                if (max < _movie[i].getReit())
                {
                    max = _movie[i].getReit();
                    index = i;

                }

            }
            MessageBox.Show($"Самый рейтинговый фильм с индексом - {index}");
            movie_listBox.SetSelected(index, true); // будет выделен  элемент
        }

        private void rating_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void movie_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получаем данные о выбранном объекте 
            string[] answr = _movie[movie_listBox.SelectedIndex].answRec();
            title_textBox.Text = answr[0];
            duration_textBox.Text = answr[1];
            year_textBox.Text = answr[2];
            genre_textBox.Text = answr[3];
            rating_textBox.Text = answr[4];
            _currentMovie = _movie[(int)movie_listBox.SelectedIndex];
           
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectange(Convert.ToDouble(rd.Next(1, 244)), Convert.ToDouble(rd.Next(1, 244)), _colors[rd.Next(0, 4)],i+1);
                rect_listBox.Items.Add($"Rectangle {i + 1}");
            }
            rect_listBox.SetSelected(0, true); // будет выделен первый элемент
            var Movie = new[]
            {
                new Movie ("Дракула",320,1999,"Ужасы",7),
                new Movie ("Золушка",170,1989,"Мультфильм",8),
                new Movie ("Зебра",620,2013,"Научный",5),
                new Movie ("Аватар2",330,2023,"Фантастика",9),
                new Movie ("Пинокио",120,2013,"Мультфильм",6)
            };
            _movie = Movie.ToArray();
            for (int j = 0; j < _movie.Length; j++)
            {
                movie_listBox.Items.Add($"Фильм {j + 1}");
            }
            movie_listBox.SetSelected(0, true); // будет выделен первый элемент
        }
    }
}
