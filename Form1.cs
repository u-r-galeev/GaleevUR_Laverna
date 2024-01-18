using GaleevUR.WeatherInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GaleevUR
{
    public partial class Form1 : Form
    {
        string descText = "Описание: ";
        string tempText = "Температура воздуха: ";
        string windText = "Скорость ветра м/с: ";


        public Form1()
        {
            InitializeComponent();
            labelDesc.Text = descText;
            labelTemp.Text = tempText;
            labelWind.Text = windText;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            //Проверка на пустое значение
            if (cityTextBox.Text != "")
            {
                //Создание строковой переменной с текстом ссылки на город, указанный в текстбоксе
                string url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityTextBox.Text + "&units=metric&appid=ef60b6254c14e189e4a72b2245283c37";
                //Создание запроса по указанной ссылке
                WebRequest webRequest = (WebRequest)WebRequest.Create(url);

                WebResponse webResponse;

                //Проверка на коррекность ввода
                try { webResponse = (WebResponse)webRequest.GetResponse(); }
                catch (WebException)
                {
                    //Действия при провале проверки
                    MessageBox.Show("Превышено время ожидания от сервера. Введите корректное название города или повторите попытку позже");
                    return;
                }
                //Получение ответа по запросу webRequest
                webResponse = (WebResponse)webRequest.GetResponse();

                string response;
                //Создание потока, выводящего данные в формате JSON 
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    //Перенос данных из JSON в строковую переменную
                    response = reader.ReadToEnd();
                }


                webResponse.Close();
                //Десериализация данных по объектам
                WeatherInfo.WeatherInfo wI = JsonConvert.DeserializeObject<WeatherInfo.WeatherInfo>(response);
                //Вывод требуемых данных в форму

                //Перевод данных в строковый формат
                string descTMP = response.Substring(response.IndexOf("\"description\":\"") + 15);
                string descResponse = descTMP.Substring(0, descTMP.IndexOf("\""));

                //Вывод данных
                labelDesc.Text = descText + descResponse;
                labelTemp.Text = tempText + wI.main.temp.ToString();
                labelWind.Text = windText + wI.wind.speed.ToString();

            }
            else
            {
                //Действия при провале проверки
                MessageBox.Show("Пожалуйста, введите название города");
            }
        }

        private void cityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Поиск информации по нажатию клавиши Enter
            if ((e.KeyCode == Keys.Enter))
            {
                buttonSelect_Click(sender, e);
            }
        }
    }
}
