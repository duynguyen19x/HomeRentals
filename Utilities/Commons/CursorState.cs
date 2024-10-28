using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Utilities.Commons
{
    public class CursorState
    {
        static bool _isBusy;

        public static void SetBusyState()
        {
            Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
            {
                SetBusyState(true);
            }));
        }

        static void SetBusyState(bool isBusy)
        {
            if (isBusy != _isBusy)
            {
                _isBusy = isBusy;
                Cursor.Current = isBusy ? Cursors.WaitCursor : Cursors.Default;

                if (_isBusy)
                {
                    new DispatcherTimer(TimeSpan.FromSeconds(0), DispatcherPriority.ApplicationIdle, DispatcherTimer_Tick, Dispatcher.CurrentDispatcher);
                }
            }
        }

        static void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            var dispatcherTimer = sender as DispatcherTimer;
            if (dispatcherTimer != null)
            {
                SetBusyState(false);
                dispatcherTimer.Stop();
            }
        }
    }
}
