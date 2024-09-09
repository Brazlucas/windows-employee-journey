using System;
using e_journey_windows.Models;
using e_journey_windows.Views;

namespace e_journey_windows.Presenters
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly WorkDayCalculator _calculator;

        public MainPresenter(IMainForm view)
        {
            _view = view;
            _calculator = new WorkDayCalculator();

            _view.CalculateEvent += OnCalculate;
            _view.SaveAndMinimizeEvent += OnSaveAndMinimize;
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            string entradaStr = _view.Entrada;
            string almocoSaidaStr = _view.AlmocoSaida;
            string almocoRetornoStr = _view.AlmocoRetorno;

            if (!_calculator.IsValidTimeFormat(entradaStr) ||
                !_calculator.IsValidTimeFormat(almocoSaidaStr) ||
                !_calculator.IsValidTimeFormat(almocoRetornoStr))
            {
                _view.ShowError("Por favor, insira horários válidos no formato HH:MM.");
                return;
            }

            TimeSpan entrada = TimeSpan.Parse(entradaStr);
            TimeSpan almocoSaida = TimeSpan.Parse(almocoSaidaStr);
            TimeSpan almocoRetorno = TimeSpan.Parse(almocoRetornoStr);

            TimeSpan horarioSaidaCalculado = _calculator.CalculateExitTime(entrada, almocoSaida, almocoRetorno);
            _view.UpdateResult($"Você pode sair às {horarioSaidaCalculado:hh\\:mm}");

            if (_view.ShouldNotify)
            {
                _view.StartNotificationTimer(horarioSaidaCalculado);
            }
        }

        private void OnSaveAndMinimize(object sender, EventArgs e)
        {
            _view.MinimizeToTray();
        }
    }
}