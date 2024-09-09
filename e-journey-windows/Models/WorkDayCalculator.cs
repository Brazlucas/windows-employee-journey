using System;

namespace e_journey_windows.Models
{
    public class WorkDayCalculator
    {
        public TimeSpan CalculateExitTime(TimeSpan entrada, TimeSpan almocoSaida, TimeSpan almocoRetorno)
        {
            TimeSpan jornadaDiaria = new TimeSpan(8, 48, 0);
            TimeSpan tempoTrabalhadoManha = almocoSaida - entrada;
            TimeSpan tempoRestante = jornadaDiaria - tempoTrabalhadoManha;
            return almocoRetorno + tempoRestante;
        }

        public bool IsValidTimeFormat(string time)
        {
            return TimeSpan.TryParseExact(time, "hh\\:mm", null, out _);
        }
    }
}