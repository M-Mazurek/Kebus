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
        private const int REFRESH_RATE = 1000;
        private readonly Func<T> _dataGetter;
        private readonly Action _onSync;
        private readonly Form _form;

        public T? CurrentData;

        public DataSyncer(Func<T> dataGetter, Action onSync, Form form)
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
            _dataGetter = dataGetter;
            _onSync = onSync;
            _form = form;
            DoWork += DataSyncer_DoWork;
            ProgressChanged += DataSyncer_Sync;
        }

        private void DataSyncer_Sync(object? sender, ProgressChangedEventArgs e)
        {
            Task.Run(() =>
            {
                T? newData = _dataGetter();
                // nie jestem z tego dumny ale żaden comparer nie zwracał równości )
                if (JsonConvert.SerializeObject(newData) != JsonConvert.SerializeObject(CurrentData))
                {
                    CurrentData = newData;
                    if (_form.IsHandleCreated)
                        _form.Invoke(_onSync);
                }
            });
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
