using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kebus
{
    public class DataSyncer<T> : BackgroundWorker
    {
        private const int REFRESH_RATE = 5000;
        private readonly Func<T> _dataGetter;
        private readonly Action _onSync;

        public T? CurrentData;

        public DataSyncer(Func<T> dataGetter, Action onSync)
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
            _dataGetter = dataGetter;
            _onSync = onSync;
            DoWork += DataSyncer_DoWork;
            ProgressChanged += DataSyncer_Sync;
        }

        private void DataSyncer_Sync(object? sender, ProgressChangedEventArgs e)
        {
            T? newData = _dataGetter();
            // nie jestem z tego dumny ale żaden comparer nie zwracał równości )
            if (JsonConvert.SerializeObject(newData) != JsonConvert.SerializeObject(CurrentData))
            {
                CurrentData = newData;
                _onSync();
            }
        }

        private void DataSyncer_DoWork(object? sender, DoWorkEventArgs e)
        {
            while (true)
            {
                ReportProgress(0);
                Thread.Sleep(REFRESH_RATE);
            }
        }
    }
}
