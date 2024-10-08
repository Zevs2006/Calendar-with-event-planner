namespace Calendar_with_event_planner
{
   partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MonthCalendar monthCalendar;
    private System.Windows.Forms.ListBox listBoxEvents;
    private System.Windows.Forms.TextBox txtEventDescription;
    private System.Windows.Forms.Button btnAddEvent;
    private System.Windows.Forms.Button btnEditEvent;
    private System.Windows.Forms.Button btnDeleteEvent;
    private System.Windows.Forms.Timer reminderTimer;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            monthCalendar = new MonthCalendar();
            listBoxEvents = new ListBox();
            txtEventDescription = new TextBox();
            btnAddEvent = new Button();
            btnEditEvent = new Button();
            btnDeleteEvent = new Button();
            reminderTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(14, 14);
            monthCalendar.Margin = new Padding(10);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            monthCalendar.DateSelected += monthCalendar_DateSelected;
            // 
            // listBoxEvents
            // 
            listBoxEvents.DisplayMember = "парпав";
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 15;
            listBoxEvents.Location = new Point(233, 14);
            listBoxEvents.Margin = new Padding(4, 3, 4, 3);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(233, 199);
            listBoxEvents.TabIndex = 1;
            listBoxEvents.Tag = "";
            // 
            // txtEventDescription
            // 
            txtEventDescription.Location = new Point(233, 220);
            txtEventDescription.Margin = new Padding(4, 3, 4, 3);
            txtEventDescription.Name = "txtEventDescription";
            txtEventDescription.Size = new Size(233, 23);
            txtEventDescription.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(233, 250);
            btnAddEvent.Margin = new Padding(4, 3, 4, 3);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(88, 27);
            btnAddEvent.TabIndex = 3;
            btnAddEvent.Text = "Добавить";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(328, 250);
            btnEditEvent.Margin = new Padding(4, 3, 4, 3);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(88, 27);
            btnEditEvent.TabIndex = 4;
            btnEditEvent.Text = "Изменить";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(422, 250);
            btnDeleteEvent.Margin = new Padding(4, 3, 4, 3);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(88, 27);
            btnDeleteEvent.TabIndex = 5;
            btnDeleteEvent.Text = "Удалить";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // reminderTimer
            // 
            reminderTimer.Interval = 60000;
            reminderTimer.Tick += reminderTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 301);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnEditEvent);
            Controls.Add(btnAddEvent);
            Controls.Add(txtEventDescription);
            Controls.Add(listBoxEvents);
            Controls.Add(monthCalendar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Календарь и планировщик событий";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }

}
