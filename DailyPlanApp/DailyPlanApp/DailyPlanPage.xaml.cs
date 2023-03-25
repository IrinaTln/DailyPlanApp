using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace DailyPlanApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyPlanPage : ContentPage
    {
        Label label;
        TimePicker time;
        Image image;
        Button button;
        Button buttonTelegramm;

        int number = 0;
        List<string> moreInfo = new List<string>()
            {
                "https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D0%BB%D0%B0%D1%82%D0%BE%D0%BD%D0%B8%D0%BD",
                "https://ru.wikipedia.org/wiki/%D0%91%D0%B5%D1%81%D1%81%D0%BE%D0%BD%D0%BD%D0%B8%D1%86%D0%B0",
                "https://ru.wikipedia.org/wiki/%D0%9F%D0%B0%D0%BD%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F_%D0%B0%D1%82%D0%B0%D0%BA%D0%B0",
                "https://ru.wikipedia.org/wiki/%D0%A2%D1%80%D0%B5%D0%B2%D0%BE%D0%B6%D0%BD%D0%BE%D1%81%D1%82%D1%8C",
                "https://ru.wikipedia.org/wiki/%D0%A1%D0%B5%D0%BB%D0%B5%D0%BA%D1%82%D0%B8%D0%B2%D0%BD%D1%8B%D0%B5_%D0%B8%D0%BD%D0%B3%D0%B8%D0%B1%D0%B8%D1%82%D0%BE%D1%80%D1%8B_%D0%BE%D0%B1%D1%80%D0%B0%D1%82%D0%BD%D0%BE%D0%B3%D0%BE_%D0%B7%D0%B0%D1%85%D0%B2%D0%B0%D1%82%D0%B0_%D1%81%D0%B5%D1%80%D0%BE%D1%82%D0%BE%D0%BD%D0%B8%D0%BD%D0%B0",
                "https://mipz.ru/samopomoshch-pri-panicheskih-atakah/",
                "https://gestaltclub.com/articles/obsaa-psihologia/11596-a-ne-takoj-kak-vse",
                "https://www.vogue.ru/beauty/pochemu-my-teryaem-appetit-ot-stressa-i-kak-perestat-eto-delat",
                "https://helpcolorplanet.ru/news/kak_spravitsya_s_emotsionalnym_vygoraniem/?gclid=Cj0KCQjwt_qgBhDFARIsABcDjOedvkGVSjEKI5QPuC1rSseXGp07JtMkG0BSRJW1vkeX1-vSHA07BjcaAtPHEALw_wcB",
                "https://www.idrlabs.com/ru/depression/test.php",
                "https://pikabu.ru/story/vsemogushchiy_kontrol_4382101",
                "https://psychologos.ru/articles/view/trudogolizm",
                "https://www.psychologies.ru/standpoint/samotsennost-kak-nauchitsya-byit-soboy/",
                "https://azarova-aleks.com/strah-odinochestva-glazami-psihologa/",
                "https://gestaltclub.com/articles/obsaa-psihologia/14822-sindrom-spasatela",
                "https://wikigrowth.com/razvitie/prinyatie-sebya/",
                "https://ru.wikipedia.org/wiki/%D0%9F%D1%81%D0%B8%D1%85%D0%BE%D1%81%D0%BE%D0%BC%D0%B0%D1%82%D0%B8%D0%BA%D0%B0",
                "https://kpt-center.com.ua/ru/stati/trevoga-vrag-ili-drug/",
                "https://gestaltclub.com/articles/psihoterapia/15310-razvod-kto-vinovat",
                "https://gestaltclub.com/articles/psihoterapia/8308-psihoterapia-travmy-rabota-s-dusevnoj-bolu",
                "https://gestaltclub.com/articles/obsaa-psihologia/5323-strah-otverzenia",
                "https://gestaltclub.com/articles/gestalt-terapia/6283-fenomen-sozavisimyh-otnosenij",
                "https://gestaltclub.com/articles/obsaa-psihologia/8725-licnye-granicy-celoveka",
                "https://gestaltclub.com/articles/obsaa-psihologia/14028-obescenivanie",

            };

        public DailyPlanPage()
        {

            time = new TimePicker
            {
                Time = new TimeSpan (12, 0, 0),
                TextColor = Color.FromHex("#2B797A"),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            label = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.FromHex("#2B797A"),
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 20,
                Margin = 5

            };

            image = new Image
            {
                Margin = 5,
            };

            button = new Button
            {
                Text = "Больше информации по теме",
                TextColor = Color.FromHex("#2B797A"),
                BackgroundColor = Color.FromHex("#B7D3E6"),
                WidthRequest = 280,
                HeightRequest = 55,
                BorderWidth = 2,
                BorderColor = Color.FromHex("#2B797A"),
                CornerRadius = 10,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            buttonTelegramm = new Button
            {
                Text = "В Telegramm к Каракатице!",
                TextColor = Color.FromHex("#2B797A"),
                BackgroundColor = Color.FromHex("#B7D3E6"),
                WidthRequest = 280,
                HeightRequest = 55,
                BorderWidth = 2,
                BorderColor = Color.FromHex("#2B797A"),
                CornerRadius = 10,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            button.IsVisible = false;
            buttonTelegramm.IsVisible = false;
            button.Clicked += Button_Clicked;
            buttonTelegramm.Clicked += Button_Clicked1;
            time.PropertyChanged += Time_PropertyChanged;
            StackLayout stack = new StackLayout
            {
                Children = {time, label, image, button, buttonTelegramm}
                
            };

            Content = stack;
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://t.me/kar_therapy");
        }

        private void Time_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var point = time.Time.Hours;
            if (point == 0)
            {
                number = 0;
                label.Text = "Сон важная часть нашей психики. Дайте ей отдохнуть!";
                image.Source = "affirm_day_0.jpg";
                button.IsVisible = true;    
                buttonTelegramm.IsVisible = true;
            }
            if (point == 1)
            {
                number = 1;
                label.Text = "Страх это чувство. Чувств у тебя много: радость, грусть... Ты больше чем твой страх.";
                image.Source = FileImageSource.FromFile("affirm_day_1.jpg");
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 2)
            {
                number = 2;
                label.Text = "Позаботьтесь о себе! Ваши переживания и сосояния здоровья важны!";
                image.Source = "affirm_day_2.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 3)
            {
                number = 3;
                label.Text = "С вами все в порядке. Чуть-чуть заботы о себе и бессонится сама ретируется.";
                image.Source = "affirm_day_3.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 4)
            {
                number = 4;
                label.Text = "Иногда вам нужна помощь. Это нормально. Это не делает вас плохим.";
                image.Source = "affirm_day_4.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 5)
            {
                number = 5;
                label.Text = "Если вы не спите в пять утра, значит есть повод пересмотреть свою нагрузку.";
                image.Source = "affirm_day_5.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 6)
            {
                number = 6;
                label.Text = "Спросите у себя, почему так сложно вставать по-утрам? Возможно за этим кроется больше, чем недостаточно сна.";
                image.Source = "affirm_day_6.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 7)
            {
                number = 7;
                label.Text = "Утро. Самое время позавтракать. Спросите у себя, что вам хочеться съесть?";
                image.Source = "affirm_day_7.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 8)
            {
                number = 8;
                label.Text = "Если с утра нет сил, это хороший повод подумать о том как себе помочь.";
                image.Source = "affirm_day_8.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 9)
            {
                number = 9;
                label.Text = "Бывают такие времена, когда встав с кровати ты уже совершил победу.";
                image.Source = "affirm_day_9.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 10)
            {
                number = 10;
                label.Text = "Всемогущий контроль - это самый короткий путь оставить себя без сил.";
                image.Source = "affirm_day_10.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 11)
            {
                number = 11;
                label.Text = "Почти полдень. Самый пик рабочего дня. Делайте перерывы, помните о себе!";
                image.Source = "affirm_day_11.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 12)
            {
                number = 12;
                label.Text = "Вы не обязаны соответствовать чужим ожиданиям. Только своим!";
                image.Source = "affirm_day_12.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 13)
            {
                number = 13;
                label.Text = "Не бойся остаться в одиночестве! Это время для встречи с самим собой. Ты прекрасен, присмотрись!";
                image.Source = "affirm_day_13.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 14)
            {
                number = 14;
                label.Text = "Если захотелось кому-то помочь без чужой просьбы, попейте кофе, посмотрите фильм.";
                image.Source = "affirm_day_14.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 15)
            {
                number = 15;
                label.Text = "Умение слушать себя, первый шаг к пониманию себя настоящего.";
                image.Source = "affirm_day_15.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 16)
            {
                number = 16;
                label.Text = "Отдых это важно. Посуда и уборка в лес не убегут. А здоровье ждать не будет.";
                image.Source = "affirm_day_16.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 17)
            {
                number = 17;
                label.Text = "Тревога - это первобытный инструмент выживания. Она не плохая и не хорошая, если не мешает нормальной жизни.";
                image.Source = "affirm_day_17.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 18)
            {
                number = 18;
                label.Text = "Если вы тревожник, не бойтесь себя защищать и делать выбор в свою пользу.";
                image.Source = "affirm_day_18.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 19)
            {
                number = 19;
                label.Text = "Иногда бывает очень больно. Позволь себе плакать и переживать. Ты достоин сочувствия.";
                image.Source = "affirm_day_19.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 20)
            {
                number = 20;
                label.Text = "А вы спокойно относитесь к объятиям? Или избегаете любых прикасновений?";
                image.Source = "affirm_day_20.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 21)
            {
                number = 21;
                label.Text = "Созависимые отношения - самое частое место обитания тревожника!";
                image.Source = "affirm_day_21.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 22)
            {
                number = 22;
                label.Text = "Обида, раздражение и даже гнев - это наши помошники. Они строго следят за нашими границами.";
                image.Source = "affirm_day_22.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
            if (point == 23)
            {
                number = 23;
                label.Text = "Обесценивание себя и своих достижений - это не честно по отношению к себе.";
                image.Source = "affirm_day_23.jpg";
                button.IsVisible = true;
                buttonTelegramm.IsVisible = true;
            }
        }

        private async void Button_Clicked(object  sender, EventArgs e)
        {
            await Browser.OpenAsync(moreInfo[index: number]);
        }
    }
}