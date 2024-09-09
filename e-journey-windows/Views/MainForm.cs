using System;
using System.Drawing;
using System.Windows.Forms;
using e_journey_windows.Presenters;

namespace e_journey_windows.Views
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly NotifyIcon notifyIcon;
        private readonly Timer notificationTimer;
        private TimeSpan horarioSaidaCalculado;

        public MainForm()
        {
            InitializeComponent();
            new MainPresenter(this); // Inicia o apresentador

            notificationTimer = new Timer { Interval = 60000 }; // 1 minuto
            notificationTimer.Tick += NotificationTimer_Tick;

            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = false,
                BalloonTipTitle = "Aplicativo Minimizado",
                BalloonTipText = "O aplicativo continuará em execução em segundo plano."
            };
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }

        public event EventHandler CalculateEvent;
        public event EventHandler SaveAndMinimizeEvent;

        public string Entrada => maskedTxtEntrada.Text;
        public string AlmocoSaida => maskedTxtAlmocoSaida.Text;
        public string AlmocoRetorno => maskedTxtAlmocoRetorno.Text;
        public bool ShouldNotify => chkNotification.Checked;

        public void UpdateResult(string message)
        {
            lblResultado.Text = message;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void StartNotificationTimer(TimeSpan horarioSaida)
        {
            horarioSaidaCalculado = horarioSaida;
            notificationTimer.Start();
        }

        public void MinimizeToTray()
        {
            notifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon.ShowBalloonTip(3000);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAndMinimizeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.TimeOfDay >= horarioSaidaCalculado)
            {
                notifyIcon.BalloonTipTitle = "Hora de sair!";
                notifyIcon.BalloonTipText = $"Você pode sair às {horarioSaidaCalculado:hh\\:mm}";
                notifyIcon.ShowBalloonTip(30000); // Mostra por 30 segundos
                notificationTimer.Stop();
            }
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }
    }
}
