using Exiled.API.Interfaces;
using System.ComponentModel;

namespace TPSDisplay
{
    public class Config : IConfig
    {
        [Description("Включён ли плагин.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Показывать ли отладочные сообщения.")]
        public bool Debug { get; set; } = false;

        [Description("Интервал обновления TPS (в секундах).")]
        public float UpdateInterval { get; set; } = 1f;

        [Description("Длительность отображения подсказки (должна быть >= UpdateInterval).")]
        public float HintDuration { get; set; } = 1.5f;

        [Description("Вертикальное смещение (отрицательное – вниз).")]
        public int VerticalOffset { get; set; } = -500;

        [Description("Горизонтальное смещение (отрицательное – влево).")]
        public int HorizontalOffset { get; set; } = 0;

        [Description("Формат сообщения. {0} подставляется значение TPS.")]
        public string MessageFormat { get; set; } = "\n\nTPS: {0:F1}";
    }
}