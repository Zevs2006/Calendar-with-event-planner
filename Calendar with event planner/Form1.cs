using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendar_with_event_planner
{
    public partial class Form1 : Form
    {
        private Dictionary<DateTime, List<string>> events = new Dictionary<DateTime, List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reminderTimer.Start();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadEventsForSelectedDate();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            string eventDescription = txtEventDescription.Text;

            if (!events.ContainsKey(selectedDate))
            {
                events[selectedDate] = new List<string>();
            }
            events[selectedDate].Add(eventDescription);
            LoadEventsForSelectedDate();
            txtEventDescription.Clear();
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Выберите событие для редактирования.");
                return;
            }

            DateTime selectedDate = monthCalendar.SelectionStart;
            string selectedEvent = listBoxEvents.SelectedItem.ToString();
            string newDescription = txtEventDescription.Text;

            if (events.ContainsKey(selectedDate))
            {
                events[selectedDate].Remove(selectedEvent);
                events[selectedDate].Add(newDescription);
                LoadEventsForSelectedDate();
                txtEventDescription.Clear();
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Выберите событие для удаления.");
                return;
            }

            DateTime selectedDate = monthCalendar.SelectionStart;
            string selectedEvent = listBoxEvents.SelectedItem.ToString();

            if (events.ContainsKey(selectedDate))
            {
                events[selectedDate].Remove(selectedEvent);
                LoadEventsForSelectedDate();
            }
        }

        private void LoadEventsForSelectedDate()
        {
            listBoxEvents.Items.Clear();
            DateTime selectedDate = monthCalendar.SelectionStart;

            if (events.ContainsKey(selectedDate))
            {
                foreach (var ev in events[selectedDate])
                {
                    listBoxEvents.Items.Add(ev);
                }
            }
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            foreach (var date in events.Keys)
            {
                foreach (var eventDescription in events[date])
                {
                    if (date.Date == currentTime.Date && eventDescription.Contains("Напоминание"))
                    {
                        MessageBox.Show($"Напоминание: {eventDescription}");
                    }
                }
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка на то, что элемент выбран
            if (listBoxEvents.SelectedItem != null)
            {
                // Возвращаем текст выбранного события в поле для ввода
                txtEventDescription.Text = listBoxEvents.SelectedItem.ToString();
            }
        }
    }
}
