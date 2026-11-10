using Airlines_Shihova.Classes;
using System;
using System.Windows.Controls;

namespace Airlines_Shihova.Elements
{
    public partial class Item : UserControl
    {
        public Item(TicketContext Ticket)
        {
            InitializeComponent();

            lPrice.Content = Ticket.Price;

            fromTime.Content = Ticket.StartTime.ToString("HH:mm");
            fromDate.Content = Ticket.StartTime.ToString("MM.dd.yyyy");
            from.Content = Ticket.From;

            toTime.Content = Ticket.EndTime.ToString("HH:mm");
            toDate.Content = Ticket.EndTime.ToString("MM.dd.yyyy");
            to.Content = Ticket.To;

            TimeSpan WayTime = Ticket.EndTime.Subtract(Ticket.StartTime);

            way.Content = "в пути:" + WayTime.ToString();
        }
    }
}
