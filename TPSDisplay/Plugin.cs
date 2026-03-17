using System;
using System.Timers;
using Exiled.API.Features;

namespace TPSDisplay
{
    public class Plugin : Plugin<Config>
    {
        private Timer _timer;

        public override void OnEnabled()
        {
            base.OnEnabled();
            _timer = new Timer(Config.UpdateInterval * 1000); // в миллисекундах
            _timer.Elapsed += UpdateTps;
            _timer.AutoReset = true;
            _timer.Start();
        }

        public override void OnDisabled()
        {
            _timer?.Stop();
            _timer?.Dispose();
            base.OnDisabled();
        }

        private void UpdateTps(object sender, ElapsedEventArgs e)
        {
            double tps = Server.Tps;
            string message = string.Format(Config.MessageFormat, tps);

            foreach (Player player in Player.List)
            {
                if (player != null && player.IsConnected)
                {
                    player.ShowHint(message, Config.HintDuration);
                }
            }
        }
    }
}