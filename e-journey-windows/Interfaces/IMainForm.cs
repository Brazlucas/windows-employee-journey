using System;

namespace e_journey_windows.Views
{
    public interface IMainForm
    {
        event EventHandler CalculateEvent;
        event EventHandler SaveAndMinimizeEvent;

        string Entrada { get; }
        string AlmocoSaida { get; }
        string AlmocoRetorno { get; }
        bool ShouldNotify { get; }

        void UpdateResult(string message);
        void ShowError(string message);
        void StartNotificationTimer(TimeSpan horarioSaida);
        void MinimizeToTray();
    }
}