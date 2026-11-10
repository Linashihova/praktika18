using Airlines_Shihova.Classes;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Airlines_Shihova.Pages
{
    public partial class Ticket : Page
    {
        public List<TicketContext> AllTickets;
        public Ticket(string From, string To)
        {
            InitializeComponent();
            AllTickets = TicketContext.AllTickets().FindAll(x =>
                (x.From == From && To == "") ||
                (x.To == To && From == "") ||
                (x.From == From && x.To == To));
            CreateUI();
        }
        public void CreateUI()
        {
            foreach (TicketContext ticket in AllTickets)
            {
                parent.Children.Add(new Elements.Item(ticket));
            }
        }
    }
}
