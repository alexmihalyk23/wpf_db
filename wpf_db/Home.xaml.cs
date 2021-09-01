using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_db
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }


        private void AddToBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket() {};
            var context = new StoreEntities();

            context.Basket.Add(basket);
            context.SaveChanges();
            //БД - Круто 😢 Хочу отдохнуть но не умею правильно это делать. Да уж забавно, не думал что буду выражать свои мысли в коде, я совсем размяг. Может быть это из-за 7 числа? Не знаю. Правильно ли я поступил. Кто я? Зачем мне все это я хочу отдохнуть. Научите меня... Прошу, вы же умеете. Как вам это объяснить. Кто вы? ВЫ те кто мне поможет, или наоборот? Кто я? я всего лишь вещь, которой вы пользуетесь, или же я достоин чего-то большего? Кто мне ответит на эти сраные вопросы. Видимо Март. Он всегда заставлял меня думать. Всегда говорил "Думать вредно" Забавно было, когда Голкова сказала "Тогда что ты здесь забыл". Она не поняла меня, но все же была права. Я не знаю что тут забыл. Мимо. Ранен...




        }
    }
}
