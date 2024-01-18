using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleevUR.WeatherInfo
{
    //Класс для получения значений
    class weather
    {
        public weather(List<WeatherInfo> list) 
        {
            List<WeatherInfo> wList = list;           
        }

        //Получение значения из переменной descrition
        public string descrition;
    }
}
